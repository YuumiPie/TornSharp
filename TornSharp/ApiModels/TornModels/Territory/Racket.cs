using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.TornModels.Territory;

public class Racket : JsonModel
{
    [JsonPropertyName("changed")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Changed { get; set; }

    [JsonPropertyName("created")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Created { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("reward")]
    public string Reward { get; set; }
}