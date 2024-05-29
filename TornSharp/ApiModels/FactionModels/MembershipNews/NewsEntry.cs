using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.FactionModels.MembershipNews;

public class NewsEntry : JsonModel
{
    [JsonPropertyName("news")]
    public string News { get; set; }

    [JsonPropertyName("timestamp")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Timestamp { get; set; }
}