using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Territory;

public class TornTerritory : JsonModel, ITornStats
{
    [JsonPropertyName("territory")]
    public Dictionary<string, Territory> Territories { get; set; }

    public string GetMethodName()
    {
        return TornMethods.territory.ToString();
    }
}