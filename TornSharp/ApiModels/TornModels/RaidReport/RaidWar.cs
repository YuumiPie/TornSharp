using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.TornModels.RaidReport;

public class RaidWar : JsonModel
{
    [JsonPropertyName("end")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime End { get; set; }

    [JsonPropertyName("start")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Start { get; set; }
}