using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Competition;

public class EliminationTeam : JsonModel
{
    [JsonPropertyName("lives")]
    public int Lives { get; set; }

    [JsonPropertyName("losses")]
    public int Losses { get; set; }

    [JsonPropertyName("name")]
    public int Name { get; set; }

    [JsonPropertyName("participants")]
    public int Participants { get; set; }

    [JsonPropertyName("position")]
    public int Position { get; set; }

    [JsonPropertyName("score")]
    public int Score { get; set; }

    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("team")]
    public int Team { get; set; }

    [JsonPropertyName("wins")]
    public int Wins { get; set; }
}