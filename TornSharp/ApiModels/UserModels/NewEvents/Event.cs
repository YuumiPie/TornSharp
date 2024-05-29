using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.UserModels.NewEvents;

public class Event : JsonModel
{
    [JsonPropertyName("event")]
    public string EventText { get; set; }

    [JsonPropertyName("seen")]
    [JsonConverter(typeof(BoolConverter))]
    public bool seen { get; set; }

    [JsonPropertyName("timestamp")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime TimeStamp { get; set; }
}