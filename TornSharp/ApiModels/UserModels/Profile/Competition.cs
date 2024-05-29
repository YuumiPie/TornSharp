using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Profile;

public class Competition : JsonModel
{
    [JsonPropertyName("attacks")]
    public string? Attacks { get; set; }

    [JsonPropertyName("image")]
    public int? Image { get; set; }

    [JsonPropertyName("name")]
    public CompetitionType Name { get; set; }

    //unknown type (assumed integer)
    [JsonPropertyName("position")]
    public object? Position { get; set; }

    [JsonPropertyName("score")]
    public double? Score { get; set; }

    [JsonPropertyName("status")]
    public RockPaperScissors? Status { get; set; }

    [JsonPropertyName("team")]
    public string? Team { get; set; }

    [JsonPropertyName("text")]
    public string? Text { get; set; }

    [JsonPropertyName("total")]
    public int? Total { get; set; }

    [JsonPropertyName("treats_collected_total")]
    public int? Rank { get; set; }

    [JsonPropertyName("votes")]
    public int? Votes { get; set; }
}