using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Competition;

public class LeaderboardPosition : JsonModel
{
    [JsonPropertyName("position")]
    public int Position { get; set; }

    [JsonPropertyName("score")]
    public double Score { get; set; }

    [JsonPropertyName("user_id")]
    public int UserId { get; set; }
}