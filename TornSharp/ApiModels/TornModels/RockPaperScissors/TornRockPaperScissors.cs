using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.RockPaperScissors;

public class TornRockPaperScissors : JsonModel, ITornStats
{
    [JsonPropertyName("rockpaperscissors")]
    public List<RockPaperScissorsScore> RockPaperScissors { get; set; }

    public string GetMethodName()
    {
        return TornMethods.rockpaperscissors.ToString();
    }
}