using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Stocks;

public class Stock : JsonModel
{
    [JsonPropertyName("benefit")]
    public Bonus? Benefit { get; set; }

    [JsonPropertyName("dividend")]
    public Bonus? Dividend { get; set; }

    [JsonPropertyName("stock_id")]
    public int StockId { get; set; }

    [JsonPropertyName("total_shares")]
    public int TotalShares { get; set; }

    [JsonPropertyName("transactions")]
    public Dictionary<string, Transaction> Transactions { get; set; }
}