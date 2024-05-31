using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.UserModels.Travel;

public class Travel : JsonModel
{
    [JsonPropertyName("Departed")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Departed { get; set; }

    [JsonPropertyName("destination")]
    public string Destination { get; set; }

    [JsonPropertyName("method")]
    public TravelMethod Method { get; set; }

    [JsonPropertyName("time_left")]
    public int TimeLeft { get; set; }

    [JsonPropertyName("timestamp")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Timestamp { get; set; }
}