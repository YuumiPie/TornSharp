using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Display;

public class Display : JsonModel
{
    [JsonPropertyName("circulation")]
    public int Circulation { set; get; }

    [JsonPropertyName("ID")]
    public int ItemId { get; set; }

    [JsonPropertyName("market_price")]
    public int MarketPrice { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("UID")]
    public int? Uid { get; set; }
}