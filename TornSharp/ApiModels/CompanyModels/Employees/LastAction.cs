using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.CompanyModels.Employees;

public class LastAction : JsonModel
{
    [JsonPropertyName("relative")]
    public string Relative { get; set; }

    [JsonPropertyName("status")]
    public LastActionStatus Status { get; set; }

    [JsonPropertyName("timestamp")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime? Timestamp { get; set; }
}