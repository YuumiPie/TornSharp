using System.Net;
using System.Text;

namespace TornSharp.Utils;

public class ApiCaller
{
    private static readonly HttpClient client = new();

    public async Task<string> GET(string url)
    {
        HttpRequestMessage request = new(HttpMethod.Get, url);
        try
        {
            HttpResponseMessage response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            byte[] test = await response.Content.ReadAsByteArrayAsync();
            return Encoding.UTF8.GetString(test);
        }
        catch (WebException e)
        {
            WebResponse errorResponse = e.Response;
            await using Stream responseStream = errorResponse.GetResponseStream();
            StreamReader reader = new(responseStream, Encoding.GetEncoding("utf-8"));
            string errorText = await reader.ReadToEndAsync();
            throw new WebException(errorText, e);
        }
    }
}