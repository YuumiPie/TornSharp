using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Bazaar;

public class Bazaar : JsonModel
{
    [JsonPropertyName("ID")]
    public int Id { get; set; }

    [JsonPropertyName("market_price")]
    public int MarketPrice { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("price")]
    public int Price { get; set; }

    [JsonPropertyName("quantity")]
    public int Quantity { set; get; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("UID")]
    public long? Uid { get; set; }
}