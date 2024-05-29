using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.RankedWars;

public class FactionRankedWars : JsonModel, IFactionStatistics
{
    [JsonPropertyName("rankedwars")]
    public Dictionary<string, RankedWar> RankedWars { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.rankedwars.ToString();
    }
}