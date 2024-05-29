using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.UserModels.Stocks;

public class Transaction : JsonModel
{
    [JsonPropertyName("bought_price")]
    public double BoughtPrice { get; set; }

    [JsonPropertyName("shares")]
    public int Shares { get; set; }

    [JsonPropertyName("time_bought")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime TimeBought { get; set; }
}