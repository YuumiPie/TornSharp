using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.TerritoryWars;

public class TornTerritoryWars : JsonModel, ITornStats
{
    [JsonPropertyName("territorywars")]
    public Dictionary<string, TerritoryWar> TerritoryWars { get; set; }

    public string GetMethodName()
    {
        return TornMethods.territorywars.ToString();
    }
}