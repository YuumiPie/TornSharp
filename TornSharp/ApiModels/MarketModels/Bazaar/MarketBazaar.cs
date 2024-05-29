using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.MarketModels.Bazaar;

public class MarketBazaar : JsonModel, IMarketStatistics
{
    [JsonPropertyName("bazaar")]
    public List<Item>? Bazaar { get; set; }

    public string GetMethodName()
    {
        return MarketMethods.bazaar.ToString();
    }
}