using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.TerritoryWarReport;

public class TerritoryWarReport : JsonModel
{
    [JsonPropertyName("factions")]
    public Dictionary<string, Faction> Clears { get; set; }

    [JsonPropertyName("territory")]
    public Territory FactionId { get; set; }

    [JsonPropertyName("war")]
    public War Joins { get; set; }
}