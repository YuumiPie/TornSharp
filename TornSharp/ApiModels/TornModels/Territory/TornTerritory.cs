using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Territory;

public class TornTerritory : JsonModel, ITornStats
{
    [JsonPropertyName("territory")]
    public Dictionary<int, Territory> Territories { get; set; }

    public string GetMethodName()
    {
        return TornMethods.territory.ToString();
    }
}