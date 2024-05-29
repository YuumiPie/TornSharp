using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Territory;

public class FactionTerritories : JsonModel, IFactionStatistics
{
    [JsonPropertyName("territory")]
    public Dictionary<int, Territory> Territories { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.territory.ToString();
    }
}