using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Hof;

public class HallOfFame : JsonModel
{
    [JsonPropertyName("attacks")]
    public Ranking Attacks { get; set; }

    [JsonPropertyName("awards")]
    public Ranking Awards { get; set; }

    [JsonPropertyName("battlestats")]
    public Ranking BattleStats { get; set; }

    [JsonPropertyName("busts")]
    public Ranking Busts { get; set; }

    [JsonPropertyName("defends")]
    public Ranking Defends { get; set; }

    [JsonPropertyName("level")]
    public Ranking Level { get; set; }

    [JsonPropertyName("networth")]
    public Ranking Networth { get; set; }

    [JsonPropertyName("offences")]
    public Ranking Offences { get; set; }

    [JsonPropertyName("rank")]
    public Ranking Rank { get; set; }

    [JsonPropertyName("revives")]
    public Ranking Revives { get; set; }

    [JsonPropertyName("traveltime")]
    public Ranking TravelTime { get; set; }

    [JsonPropertyName("workstats")]
    public Ranking WorkStats { get; set; }
}