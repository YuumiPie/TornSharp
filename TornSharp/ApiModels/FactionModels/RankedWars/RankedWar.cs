using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.RankedWars;

public class RankedWar : JsonModel
{
    [JsonPropertyName("target")]
    public Dictionary<int, Faction> Target { get; set; }

    [JsonPropertyName("winner")]
    public War Winner { get; set; }
}