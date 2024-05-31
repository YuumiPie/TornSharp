using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.TerritoryNews;

public class FactionTerritoryNews : JsonModel, IFactionStats
{
    [JsonPropertyName("territorynews")]
    public Dictionary<int, NewsEntry> TerritoryNews { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.territorynews.ToString();
    }
}