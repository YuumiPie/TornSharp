using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.FactionTree;

public class TornFactionTree : JsonModel, ITornStats
{
    [JsonPropertyName("factiontree")]
    public Dictionary<int, Dictionary<int, Level>> FactionTree { get; set; }

    public string GetMethodName()
    {
        return TornMethods.factiontree.ToString();
    }
}