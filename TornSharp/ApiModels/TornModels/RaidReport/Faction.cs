using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.RaidReport;

public class Faction : JsonModel
{
    [JsonPropertyName("attacks")]
    public int Attacks { get; set; }

    [JsonPropertyName("members")]
    public Dictionary<int, User> Members { get; set; }

    [JsonPropertyName("name")]
    public int Name { get; set; }

    [JsonPropertyName("score")]
    public int Score { get; set; }

    [JsonPropertyName("type")]
    public RaidType Type { get; set; }
}