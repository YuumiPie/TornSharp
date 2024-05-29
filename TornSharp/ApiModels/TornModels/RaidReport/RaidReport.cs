using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.RaidReport;

public class RaidReport : JsonModel
{
    [JsonPropertyName("factions")]
    public Dictionary<string, Faction> Factions { get; set; }

    [JsonPropertyName("war")]
    public RaidWar War { get; set; }
}