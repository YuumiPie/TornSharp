using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.MarketModels.ItemMarket;

public class MarketItemMarket : JsonModel, IMarketStats
{
    [JsonPropertyName("itemmarket")]
    public List<Item>? ItemMarket { get; set; }

    public string GetMethodName()
    {
        return MarketMethods.itemmarket.ToString();
    }
}