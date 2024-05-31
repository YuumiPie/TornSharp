using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Stocks;

public class UserStocks : JsonModel, IUserStats
{
    [JsonPropertyName("stocks")]
    public List<KeyValuePair<int, Stock>> Stocks { get; set; }

    public string GetMethodName()
    {
        return UserMethods.stocks.ToString();
    }
}