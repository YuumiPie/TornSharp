using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Basic;

public class RankedWar : JsonModel
{
    [JsonPropertyName("factions")]
    public Dictionary<long, Faction> Factions { get; set; }

    [JsonPropertyName("war")]
    public War War { get; set; }
}