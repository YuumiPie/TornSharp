using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.FactionModels.Chain;

public class Chain : JsonModel
{
    [JsonPropertyName("cooldown")]
    public int Cooldown { get; set; }

    [JsonPropertyName("current")]
    public int Current { get; set; }

    [JsonPropertyName("end")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime End { get; set; }

    [JsonPropertyName("max")]
    public int Max { get; set; }

    [JsonPropertyName("modifier")]
    public double Modifier { get; set; }

    [JsonPropertyName("start")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Start { get; set; }

    [JsonPropertyName("timeout")]
    public int Timeout { get; set; }
}