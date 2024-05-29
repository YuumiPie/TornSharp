using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Gyms;

public class Gym : JsonModel
{
    [JsonPropertyName("cost")]
    public int Cost { get; set; }

    [JsonPropertyName("defense")]
    public int Defense { get; set; }

    [JsonPropertyName("dexterity")]
    public int Dexterity { get; set; }

    [JsonPropertyName("energy")]
    public int Energy { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("note")]
    public string Note { get; set; }

    [JsonPropertyName("speed")]
    public int Speed { get; set; }

    [JsonPropertyName("stage")]
    public int Stage { get; set; }

    [JsonPropertyName("strength")]
    public int Strength { get; set; }
}