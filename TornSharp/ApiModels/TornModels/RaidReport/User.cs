using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.RaidReport;

public class User : JsonModel
{
    [JsonPropertyName("attacks")]
    public int Attacks { get; set; }

    [JsonPropertyName("damage")]
    public double Damage { get; set; }

    [JsonPropertyName("faction_id")]
    public int FactionId { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}