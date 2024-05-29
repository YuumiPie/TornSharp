using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.ItemStats;

public class ItemStat : JsonModel
{
    [JsonPropertyName("ID")]
    public int Id { get; set; }

    [JsonPropertyName("market_price")]
    public int MarketPrice { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("stats")]
    public Stats Stats { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("UID")]
    public int Uid { get; set; }
}