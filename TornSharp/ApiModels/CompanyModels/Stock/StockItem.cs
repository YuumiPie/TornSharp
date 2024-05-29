using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.CompanyModels.Stock;

public class StockItem : JsonModel
{
    [JsonPropertyName("cost")]
    public int Cost { get; set; }

    [JsonPropertyName("in_stock")]
    public int InStock { get; set; }

    [JsonPropertyName("on_order")]
    public int OnOrder { get; set; }

    [JsonPropertyName("price")]
    public int Price { get; set; }

    [JsonPropertyName("rrp")]
    public int Rrp { get; set; }

    [JsonPropertyName("sold_amount")]
    public int SoldAmount { get; set; }

    [JsonPropertyName("sold_worth")]
    public int SoldWorth { get; set; }
}