using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Applications;

public class Stats : JsonModel
{
    [JsonPropertyName("defense")]
    public int Defense { get; set; }

    [JsonPropertyName("dexterity")]
    public int Dexterity { get; set; }

    [JsonPropertyName("speed")]
    public int Speed { get; set; }

    [JsonPropertyName("strength")]
    public int Strength { get; set; }
}