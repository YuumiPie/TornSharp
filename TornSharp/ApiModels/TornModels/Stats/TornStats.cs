using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Stats;

public class TornStats : JsonModel, ITornStats
{
    [JsonPropertyName("stats")]
    public Stats Stats { get; set; }

    public string GetMethodName()
    {
        return TornMethods.stats.ToString();
    }
}