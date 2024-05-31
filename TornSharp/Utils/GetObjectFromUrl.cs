using System.Data;
using System.Text.Json;
using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;
using TornSharp.Exceptions;
using TornSharp.JsonDeserializerOptions;

namespace TornSharp.Utils;

public class ObjectFromUrl
{
    private ApiCaller apiCaller = new();
    private JsonSerializerOptions options = new();

    public ObjectFromUrl()
    {
        options.Converters.Add(new JsonStringEnumConverterWithAttributeSupport());
        options.Converters.Add(new NullableConverterFactory());
        options.Converters.Add(new BracketEmptyArrayConverter());
        options.Converters.Add(new BlankStringToNumberConverter());
        options.Converters.Add(new NumberToStringConverter());
    }

    public async Task<T> GetObject<T>(string url)
    {
        string response;
        try
        {
            response = await apiCaller.GET(url);
        }
        catch (HttpRequestException e)
        {
            throw new HttpRequestException("Error Getting Response - " + e.Message, e);
        }

        //Torn Api has two error types but they both have a json key of "error"
        JsonDocument jsonDoc = JsonDocument.Parse(response);
        if (jsonDoc.RootElement.TryGetProperty("error", out JsonElement error))
        {
            throw new TornSharpErrorJsonException($"{url} call returned error json", error.GetRawText());
        }

        try
        {
            T? model = JsonSerializer.Deserialize<T>(response, options);
            if (model is null)
            {
                throw new NoNullAllowedException();
            }
            return model;
        }
        catch (Exception e)
        {
            throw new Exception("Error converting Response", e);
        }
    }
}