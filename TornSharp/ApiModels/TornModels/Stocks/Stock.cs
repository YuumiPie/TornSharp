using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Stocks;

public class Stock : JsonModel
{
    [JsonPropertyName("acronym")]
    public string? Acronym { get; set; }

    [JsonPropertyName("all_time")]
    public Price? AllTime { get; set; }

    [JsonPropertyName("benefit")]
    public Benefit? Benifit { get; set; }

    [JsonPropertyName("current_price")]
    public double CurrentPrice { get; set; }

    [JsonPropertyName("history")]
    public List<History>? History { get; set; }

    [JsonPropertyName("investors")]
    public int Investors { get; set; }

    [JsonPropertyName("last_day")]
    public Price? LastDay { get; set; }

    [JsonPropertyName("last_hour")]
    public Price? LastHour { get; set; }

    [JsonPropertyName("last_month")]
    public Price? LastMonth { get; set; }

    [JsonPropertyName("last_week")]
    public Price? LastWeek { get; set; }

    [JsonPropertyName("last_year")]
    public Price? LastYear { get; set; }

    [JsonPropertyName("market_cap")]
    public long MarketCap { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("stock_id")]
    public int StockId { get; set; }

    [JsonPropertyName("total_shares")]
    public long TotalShares { get; set; }
}