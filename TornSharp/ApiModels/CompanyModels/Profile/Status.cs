using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.CompanyModels.Profile;

public class Status : JsonModel
{
    [JsonPropertyName("color")]
    public StatusColor Color { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("details")]
    public string Details { get; set; }

    [JsonPropertyName("state")]
    public StatusState State { get; set; }

    [JsonPropertyName("until")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Until { get; set; }
}