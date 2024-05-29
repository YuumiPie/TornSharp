using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.TerritoryNames;

public class TornTerritoryNames : JsonModel, ITornStats
{
    [JsonPropertyName("territoryNames")]
    public List<string> TerritoryNames { get; set; }

    public string GetMethodName()
    {
        return TornMethods.territorynames.ToString();
    }
}