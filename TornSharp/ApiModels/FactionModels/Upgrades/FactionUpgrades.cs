using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Upgrades;

public class FactionUpgrades : JsonModel, IFactionStatistics
{
    [JsonPropertyName("peace")]
    public Dictionary<int, Upgrade> Peace { get; set; }

    [JsonPropertyName("state")]
    public State State { get; set; }

    [JsonPropertyName("upgrades")]
    public Dictionary<int, Upgrade> Upgrades { get; set; }

    [JsonPropertyName("war")]
    public Dictionary<int, Upgrade> War { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.upgrades.ToString();
    }
}