using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.TornModels.RankedWarReport;

public class War : JsonModel
{
    [JsonPropertyName("end")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime End { get; set; }

    [JsonPropertyName("forfeit")]
    [JsonConverter(typeof(BoolConverter))]
    public bool Forfeit { get; set; }

    [JsonPropertyName("start")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Start { get; set; }

    [JsonPropertyName("winner")]
    public int Winner { get; set; }
}