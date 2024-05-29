using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.TerritoryWarReport;

public class TornTerritoryWarReport : JsonModel, ITornStats
{
    [JsonPropertyName("territorywarreport")]
    public TerritoryWarReport TerritoryWarReport { get; set; }

    public string GetMethodName()
    {
        return TornMethods.territorywarreport.ToString();
    }
}