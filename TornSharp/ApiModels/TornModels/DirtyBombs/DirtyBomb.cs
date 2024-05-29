using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.TornModels.DirtyBombs;

public class DirtyBomb : JsonModel
{
    [JsonPropertyName("detonated")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Detonated { get; set; }

    [JsonPropertyName("faction")]
    public int Faction { get; set; }

    [JsonPropertyName("injured")]
    public int Injured { get; set; }

    [JsonPropertyName("planted")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Planted { get; set; }

    [JsonPropertyName("respect")]
    public int Respect { get; set; }

    [JsonPropertyName("user")]
    public int? User { get; set; }
}