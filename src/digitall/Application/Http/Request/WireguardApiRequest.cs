using System.Net;
using Domain.Exceptions;
using Newtonsoft.Json;
using MediaTypeHeaderValue = System.Net.Http.Headers.MediaTypeHeaderValue;

namespace Application.Http.Request;

public class WireguardApiRequest
{
    public async Task<ResponseWireguard> SendAsync(RequestWireguard request)
    {
        HttpClient httpClient = new HttpClient();

        var (url, method, data, headers, hasToken) = request;

        HttpRequestMessage req = new HttpRequestMessage(method, url);

        if (data != null)
        {
            req.Content = new StringContent(JsonConvert.SerializeObject(data));
            req.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        }

        var response = await httpClient.SendAsync(req);
        var responseData = await response.Content.ReadAsStringAsync();

        if (response.StatusCode != HttpStatusCode.OK) throw new MarzbanException(response.StatusCode, responseData);

        ResponseWireguard? obj = JsonConvert.DeserializeObject<ResponseWireguard>(responseData);
        return obj;
    }

    // public async Task<ResponseWireguard<ResponseWireguard>?> PostAsync<TResponse,TRequest>
    //     (TRequest request)  where TResponse : ResponseWireguard,ResponseWireguard<TResponse>
    // {
    //     var (url, method, data, headers, hasToken) = request;
    //
    //     HttpRequestMessage req = new HttpRequestMessage(method, url);
    //
    //     if (data != null)
    //     {
    //         req.Content = new StringContent(JsonConvert.SerializeObject(data));
    //         req.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
    //     }
    //
    //     var response = await httpClient.SendAsync(req);
    //     var responseData = await response.Content.ReadAsStringAsync();
    //     if (response.StatusCode != HttpStatusCode.OK) throw new MarzbanException(response.StatusCode, responseData);
    //
    //     ResponseWireguard<TResponse>? obj = JsonConvert.DeserializeObject<ResponseWireguard<TResponse>>(responseData);
    //
    //     if (obj.IsSuccess)
    //         return obj;
    //     else
    //     {
    //         throw new AppException("متسفانه مشکلی در هنگام ساخت سرویس وایرگارد پیش آمد");
    //     }
    // }
}

public class WireguardApiRequest<TResponse, TRequest>(HttpClient httpClient)
    where TRequest : RequestWireguard
{
    public async Task<ResponseWireguard<TResponse>?> PostAsync(TRequest request)
    {
        var (url, method, data, headers, hasToken) = request;

        HttpRequestMessage req = new HttpRequestMessage(method, url);

        if (data != null)
        {
            req.Content = new StringContent(JsonConvert.SerializeObject(data));
            req.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        }

        var response = await httpClient.SendAsync(req);
        var responseData = await response.Content.ReadAsStringAsync();
        if (response.StatusCode != HttpStatusCode.OK) throw new MarzbanException(response.StatusCode, responseData);

        ResponseWireguard<TResponse>? obj = JsonConvert.DeserializeObject<ResponseWireguard<TResponse>>(responseData);

        if (obj.IsSuccess)
            return obj;
        else
        {
            throw new AppException("متاسفانه مشکلی در هنگام ساخت سرویس وایرگارد پیش آمد");
        }
    }
}

public record RequestWireguard(
    string Url,
    HttpMethod Method,
    object? Data = null,
    Dictionary<string, string>? Headers = null,
    bool HasToken = false);

public class ResponseWireguard<TData>
{
    public TData? Data { get; set; }
    public bool IsSuccess { get; set; }
    public int StatusCode { get; set; }
    public string? Message { get; set; }
    public string? JsonValidationMessage { get; set; }
}

public class ResponseWireguard
{
    public object? Data { get; set; }
    public bool IsSuccess { get; set; }
    public int StatusCode { get; set; }
    public string? Message { get; set; }
    public string? JsonValidationMessage { get; set; }
}