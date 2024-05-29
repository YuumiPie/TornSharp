using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.RockPaperScissors;

public class RockPaperScissorsScore : JsonModel
{
    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("type")]
    public RockPaperScissorsStatus Type { get; set; }
}