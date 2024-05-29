using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.PropertyModels.TimeStamp;

public class PropertyTimestamp : JsonModel, IPropertyStatistics
{
    [JsonPropertyName("timestamp")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Timestamp { get; set; }

    public string GetMethodName()
    {
        return PropertyMethods.timestamp.ToString();
    }
}