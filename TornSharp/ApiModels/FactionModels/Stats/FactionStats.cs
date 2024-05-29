using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Stats;

public class FactionStats : JsonModel, IFactionStatistics
{
    [JsonPropertyName("stats")]
    public Stats Stats { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.stats.ToString();
    }
}