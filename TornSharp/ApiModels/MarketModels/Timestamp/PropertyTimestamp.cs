using System.Text.Json.Serialization;
using TornSharp.ApiModels.PropertyModels;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.MarketModels.Timestamp;

public class PropertyTimestamp : JsonModel, IMarketStatistics
{
    [JsonPropertyName("timestamp")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Timestamp { get; set; }

    public string GetMethodName()
    {
        return PropertyMethods.timestamp.ToString();
    }
}