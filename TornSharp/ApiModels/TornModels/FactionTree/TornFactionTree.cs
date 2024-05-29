using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.FactionTree;

public class TornFactionTree : JsonModel, ITornStats
{
    [JsonPropertyName("factiontree")]
    public Dictionary<string, Dictionary<string, Level>> FactionTree { get; set; }

    public string GetMethodName()
    {
        return TornMethods.factiontree.ToString();
    }
}