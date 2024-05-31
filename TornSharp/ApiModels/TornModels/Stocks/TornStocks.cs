using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Stocks;

public class TornStocks : JsonModel, ITornStats
{
    [JsonPropertyName("stocks")]
    public Dictionary<int, Stock> Stocks { get; set; }

    public string GetMethodName()
    {
        return TornMethods.stocks.ToString();
    }
}