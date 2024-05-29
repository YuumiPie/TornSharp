using System.Text.Json.Serialization;
using TornSharp.ApiModels.UserModels.Profile;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.FactionModels.RevivesFull;

public class ReviveLastAction : JsonModel
{
    [JsonPropertyName("status")]
    public LastActionStatus Status { get; set; }

    [JsonPropertyName("timestamp")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Timestamp { get; set; }
}