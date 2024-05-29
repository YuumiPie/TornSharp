using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.CompanyModels.Timestamp;

public class CompanyTimestamp : JsonModel, ICompanyStatistics
{
    [JsonPropertyName("timestamp")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Timestamp { get; set; }

    public string GetMethodName()
    {
        return CompanyMethods.timestamp.ToString();
    }
}