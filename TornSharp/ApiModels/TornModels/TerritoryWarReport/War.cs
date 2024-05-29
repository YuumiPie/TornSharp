using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.TornModels.TerritoryWarReport;

public class War : JsonModel
{
    [JsonPropertyName("end")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime End { get; set; }

    [JsonPropertyName("result")]
    public WarResult Result { get; set; }

    [JsonPropertyName("start")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Start { get; set; }

    [JsonPropertyName("winner")]
    public int Winner { get; set; }
}