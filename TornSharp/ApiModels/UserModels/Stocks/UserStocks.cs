using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Stocks;

public class UserStocks : JsonModel, IUserStatistics
{
    [JsonPropertyName("stocks")]
    public Dictionary<string, Stock> Stocks { get; set; }

    public string GetMethodName()
    {
        return UserMethods.stocks.ToString();
    }
}