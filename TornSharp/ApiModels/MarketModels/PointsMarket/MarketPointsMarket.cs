using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.MarketModels.PointsMarket;

public class MarketPointsMarket : JsonModel, IMarketStats
{
    [JsonPropertyName("pointsmarket")]
    public Dictionary<int, Point> PointsMarket { get; set; }

    public string GetMethodName()
    {
        return MarketMethods.pointsmarket.ToString();
    }
}