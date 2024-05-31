using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.UserModels.Stocks;

public class Bonus : JsonModel
{
    [JsonPropertyName("frequency")]
    public int Frequency { get; set; }

    [JsonPropertyName("increment")]
    public int Increment { get; set; }

    [JsonPropertyName("progress")]
    public int Progress { get; set; }

    [JsonPropertyName("ready")]
    [JsonConverter(typeof(BoolConverter))]
    public bool Ready { get; set; }
}