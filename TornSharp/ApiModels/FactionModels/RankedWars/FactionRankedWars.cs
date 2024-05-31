using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.RankedWars;

public class FactionRankedWars : JsonModel, IFactionStats
{
    [JsonPropertyName("rankedwars")]
    public Dictionary<int, RankedWar> RankedWars { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.rankedwars.ToString();
    }
}