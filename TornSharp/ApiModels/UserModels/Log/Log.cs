using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;
using TornSharp.JsonDeserializerOptions;

namespace TornSharp.ApiModels.UserModels.Log;

public class Log : JsonModel
{
    [JsonPropertyName("category")]
    public string Catagory { get; set; }

    [JsonPropertyName("data")]
    public Dictionary<string, string> Data { get; set; }

    [JsonPropertyName("log")]
    public int LogId { get; set; }

    [JsonPropertyName("params")]
    public Dictionary<string, string> Parameters { get; set; }

    [JsonPropertyName("timestamp")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Timestamp { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }
}