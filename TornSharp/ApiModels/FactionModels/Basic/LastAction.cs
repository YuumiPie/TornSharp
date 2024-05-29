using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Basic;

public class LastAction : JsonModel
{
    [JsonPropertyName("relative")]
    public string Relative { get; set; }

    [JsonPropertyName("status")]
    public LastActionStatus Status { get; set; }

    [JsonPropertyName("timestamp")]
    [JsonConverter(typeof(DateTime))]
    public DateTime? Timestamp { get; set; }
}