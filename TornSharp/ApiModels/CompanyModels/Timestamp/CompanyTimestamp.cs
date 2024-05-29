using System.Text.Json.Serialization;
using TornSharp.ApiModels.TornModels;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.CompanyModels.Timestamp;

public class CompanyTimestamp : JsonModel, ITornStats
{
    [JsonPropertyName("timestamp")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Timestamp { get; set; }

    public string GetMethodName()
    {
        return CompanyMethods.timestamp.ToString();
    }
}