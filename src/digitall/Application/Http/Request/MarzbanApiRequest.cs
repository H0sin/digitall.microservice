using System.Net;
using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Text;
using Application.Extensions;
using Application.Utilities;
using Domain.Entities.Server;
using Domain.Enums;
using Newtonsoft.Json;
using Domain.Entities.Marzban;
using Domain.Exceptions;

namespace Application.Http.Request;

public class MarzbanApiRequest
{
    private readonly HttpClient _httpClient;
    private string _token;
    private MarzbanServer _marzbanServer;

    public MarzbanApiRequest(MarzbanServer marzbanServer)
    {
        _httpClient = new HttpClient();
        _marzbanServer = marzbanServer;
        _token = marzbanServer.Token ?? "";
    }

    public async Task<string> LoginAsync(bool newToken = false)
    {
        try
        {
            if (_marzbanServer.Token != null) return _marzbanServer.Token;
            
            var loginData = new Dictionary<string, string?>()
            {
                { "username", _marzbanServer?.UserName },
                { "password", _marzbanServer?.Password }
            };
            
            var content = new FormUrlEncodedContent(loginData);
            var response =
                await _httpClient.PostAsync(_marzbanServer?.GetFullIpAddress() + MarzbanPaths.Login, content);

            if (response.StatusCode == HttpStatusCode.NotFound) throw new LogicException("سرور در دست رس نیست");

            var responseData = await response.Content.ReadAsStringAsync();
            var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(responseData);

            _token = tokenResponse.access_token;

            return _token;
        }
        catch (Exception e)
        { 
            await Task.CompletedTask;
            return "";
        }
    }

    public async Task<T> CallApiAsync<T>(string url, HttpMethod method, object data = null,
        Dictionary<string, string> headers = null, bool hasToken = false)
    {
        if (!hasToken) _token = await LoginAsync();

        HttpRequestMessage request = new HttpRequestMessage(method, _marzbanServer.GetFullIpAddress() + url);

        if (!string.IsNullOrEmpty(_token))
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _token);
        }

        if (headers is not null)
        {
            foreach (KeyValuePair<string, string> keyValuePair in headers)
            {
                request.Headers.Add(keyValuePair.Key, keyValuePair.Value);
            }
        }

        if (data != null)
        {
            request.Content = new StringContent(JsonConvert.SerializeObject(data));
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        }

        var response = await _httpClient.SendAsync(request);
        var responseData = await response.Content.ReadAsStringAsync();
        
        return response.StatusCode switch
        {
            HttpStatusCode.OK => JsonConvert.DeserializeObject<T>(responseData),
            HttpStatusCode.NotFound => throw new MarzbanException(ApiResultStatusCode.NotFound, responseData),
            _ => throw new MarzbanException(responseData)
        }; 
    }

    public async Task<string> CallApiAsync(string url, HttpMethod method, object data = null,
        Dictionary<string, string> headers = null, bool hasToken = false)
    {
        if (!hasToken) _token = await LoginAsync();

        HttpRequestMessage request = new HttpRequestMessage(method, _marzbanServer.GetFullIpAddress() + url);

        if (!string.IsNullOrEmpty(_token))
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _token);
        }

        if (headers is not null)
        {
            foreach (KeyValuePair<string, string> keyValuePair in headers)
            {
                request.Headers.Add(keyValuePair.Key, keyValuePair.Value);
            }
        }

        if (data != null)
        {
            request.Content = new StringContent(JsonConvert.SerializeObject(data));
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
        }

        HttpResponseMessage response = await _httpClient.SendAsync(request);
        var responseData = await response.Content.ReadAsStringAsync();
        return response.StatusCode switch
        {
            HttpStatusCode.OK => responseData,
            HttpStatusCode.NotFound => throw new MarzbanException(ApiResultStatusCode.NotFound, responseData),
            _ => throw new MarzbanException(responseData)
        }; 
        
    }

    public class TokenResponse
    {
        public string access_token { get; set; } // نام فیلد توکن در پاسخ
    }
}