using System.Text.Json.Serialization;
using TornSharp.ApiModels.TornModels.ChainReport;

namespace TornSharp.ApiModels.TornModels.RaidReport;

public class Faction : JsonModel
{
    [JsonPropertyName("attacks")]
    public int Attacks { get; set; }

    [JsonPropertyName("members")]
    public Dictionary<string, Member> Members { get; set; }

    [JsonPropertyName("name")]
    public int Name { get; set; }

    [JsonPropertyName("score")]
    public int Score { get; set; }

    [JsonPropertyName("type")]
    public RaidType Type { get; set; }
}