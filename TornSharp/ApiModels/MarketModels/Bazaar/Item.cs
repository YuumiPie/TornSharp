using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.MarketModels.Bazaar;

public class Item : JsonModel
{
    [JsonPropertyName("cost")]
    public long Cost { get; set; }

    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }
}