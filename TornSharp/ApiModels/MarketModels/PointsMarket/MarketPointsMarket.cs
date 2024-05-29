using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.MarketModels.PointsMarket;

public class MarketPointsMarket : JsonModel, IMarketStatistics
{
    [JsonPropertyName("pointsmarket")]
    public Dictionary<string, Point> PointsMarket { get; set; }

    public string GetMethodName()
    {
        return MarketMethods.pointsmarket.ToString();
    }
}