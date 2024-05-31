using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.RankedWars;

public class RankedWar : JsonModel
{
    [JsonPropertyName("factions")]
    public Dictionary<int, Faction> Points { get; set; }

    [JsonPropertyName("war")]
    public War War { get; set; }
}