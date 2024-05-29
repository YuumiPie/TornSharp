using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Money;

public class CityBank : JsonModel
{
    [JsonPropertyName("amount")]
    public long Amount { get; set; }

    [JsonPropertyName("time_left")]
    public int TimeLeft { get; set; }
}