using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using Application.Extensions;
using Application.Static;
using Domain.DTOs.Server;
using Newtonsoft.Json;

namespace Application.Http.Request;

public static class RequestHandler
{
    public static async Task<T> PostRequestAsync<T>(string path, object body, ServerDto server)
        where T : class
    {
        try
        {
            using var client = new HttpClient();


            object loginObj = new
            {
                server.UserName,
                server.Password
            };

            StringContent loginContent =
                new StringContent(loginObj.LowercaseContractResolver(), Encoding.UTF8, "application/json");

            string host = server.ServerAddress
                .Replace("https://", "")
                .Replace("http://", "")
                .Split("/")[0];

            HttpResponseMessage loginResponse =
                await client.PostAsync(server.ServerAddress + ":" + server.Port + PathUri.Login, loginContent);

            var cookie = loginResponse.Headers.SingleOrDefault(x => x.Key == "Set-Cookie").Value;

            client.DefaultRequestHeaders.Add("Cookie", cookie);
            client.DefaultRequestHeaders.Add("Host", host);

            string bodyStr = JsonConvert.SerializeObject(body, Formatting.Indented);
            StringContent content =
                new StringContent(bodyStr, Encoding.UTF8, "application/json");

            HttpResponseMessage? response =
                await client.PostAsync(server.ServerAddress + ":" + server.Port + path, content);

            string result = await response.Content.ReadAsStringAsync();

            T objRes = JsonConvert.DeserializeObject<T>(result);

            return objRes;
        }
        catch (Exception e)
        {
            throw new ApplicationException("ارتباطی با سرور برقرار نشد");
        }
    }

    public static async Task<T> GetRequestAsync<T>(string path, ServerDto server)
        where T : class
    {
        try
        {
            using (var client = new HttpClient())
            {
                object loginObj = new
                {
                    server.UserName,
                    server.Password
                };

                StringContent loginContent =
                    new StringContent(loginObj.LowercaseContractResolver(), Encoding.UTF8, "application/json");

                string host = server.ServerAddress
                    .Replace("https://", "")
                    .Replace("http://", "")
                    .Split("/")[0];

                HttpResponseMessage loginResponse =
                    await client.PostAsync(server.ServerAddress + ":" + server.Port + PathUri.Login, loginContent);

                var cookie = loginResponse.Headers.SingleOrDefault(x => x.Key == "Set-Cookie").Value;

                client.DefaultRequestHeaders.Add("Cookie", cookie);
                client.DefaultRequestHeaders.Add("Host", host);


                HttpResponseMessage? response = await client.GetAsync(server.ServerAddress + ":" + server.Port + path);

                string result = await response.Content.ReadAsStringAsync();

                T objRes = JsonConvert.DeserializeObject<T>(result);

                return objRes;
            }
        }
        catch (Exception e)
        {
            throw new ApplicationException("ارتباطی با سرور برقرار نشد");
        }
    }
}

