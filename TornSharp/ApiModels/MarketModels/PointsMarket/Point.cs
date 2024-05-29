using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.MarketModels.PointsMarket;

public class Point : JsonModel
{
    [JsonPropertyName("cost")]
    public int Cost { get; set; }

    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }

    [JsonPropertyName("total_cost")]
    public int TotalCost { get; set; }
}