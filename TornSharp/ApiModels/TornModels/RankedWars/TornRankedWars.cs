using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.RankedWars;

public class TornRankedWars : JsonModel, ITornStats
{
    [JsonPropertyName("rankedwars")]
    public Dictionary<string, RankedWar> RankedWars { get; set; }

    public string GetMethodName()
    {
        return TornMethods.rankedwars.ToString();
    }
}