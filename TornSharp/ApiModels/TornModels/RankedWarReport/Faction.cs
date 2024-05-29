using System.Text.Json.Serialization;
using TornSharp.ApiModels.TornModels.ChainReport;

namespace TornSharp.ApiModels.TornModels.RankedWarReport;

public class Faction : JsonModel
{
    [JsonPropertyName("attacks")]
    public int Attacks { get; set; }

    [JsonPropertyName("members")]
    public Dictionary<string, Member> Members { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("rank_after")]
    public string RankAfter { get; set; }

    [JsonPropertyName("rank_before")]
    public string RankBefore { get; set; }

    [JsonPropertyName("rewards")]
    public Rewards Rewards { get; set; }

    [JsonPropertyName("score")]
    public int Score { get; set; }
}