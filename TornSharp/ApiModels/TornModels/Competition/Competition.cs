using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Competition;

public class Competition : JsonModel
{
    [JsonPropertyName("leaderboardmr")]
    public List<LeaderboardPosition>? LeaderboardMr { get; set; }

    [JsonPropertyName("leaderboardmrs")]
    public List<LeaderboardPosition>? LeaderboardMrs { get; set; }

    [JsonPropertyName("name")]
    public CompetitionType Name { get; set; }

    [JsonPropertyName("teams")]
    public List<EliminationTeam>? Teams { get; set; }
}