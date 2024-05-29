using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.ItemStats;

public class TornItemStats : JsonModel, ITornStats
{
    [JsonPropertyName("itemstats")]
    public Dictionary<string, ItemStat> ItemStats { get; set; }

    public string GetMethodName()
    {
        return TornMethods.itemstats.ToString();
    }
}