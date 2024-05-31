using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Territory;

public class FactionTerritories : JsonModel, IFactionStats
{
    [JsonPropertyName("territory")]
    public Dictionary<string, Territory> Territories { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.territory.ToString();
    }
}