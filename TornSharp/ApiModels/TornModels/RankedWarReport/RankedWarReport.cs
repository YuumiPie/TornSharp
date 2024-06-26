using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.RankedWarReport;

public class RankedWarReport : JsonModel
{
    [JsonPropertyName("factions")]
    public Dictionary<int, Faction> Points { get; set; }

    [JsonPropertyName("war")]
    public War War { get; set; }
}