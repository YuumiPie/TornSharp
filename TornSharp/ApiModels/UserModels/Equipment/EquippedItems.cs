using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Equipment;

public class EquippedItems : JsonModel
{
    [JsonPropertyName("equipped")]
    public int Equipped { get; set; }

    [JsonPropertyName("ID")]
    public int Id { get; set; }

    [JsonPropertyName("market_price")]
    public int MarketPrice { get; set; }

    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("UID")]
    public long Uid { get; set; }
}