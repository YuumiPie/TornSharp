using System.Text.Json.Serialization;
using TornSharp.ApiModels.TornModels;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.FactionModels.Timestamp;

public class FactionTimestamp : JsonModel, ITornStats
{
    [JsonPropertyName("timestamp")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Timestamp { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.timestamp.ToString();
    }
}