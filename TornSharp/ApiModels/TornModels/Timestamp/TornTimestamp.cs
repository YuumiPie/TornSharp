using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.TornModels.Timestamp;

public class TornTimestamp : JsonModel, ITornStats
{
    [JsonPropertyName("timestamp")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Timestamp { get; set; }

    public string GetMethodName()
    {
        return TornMethods.timestamp.ToString();
    }
}