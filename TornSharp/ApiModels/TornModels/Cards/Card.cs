using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;
using TornSharp.JsonDeserializerOptions;

namespace TornSharp.ApiModels.TornModels.Cards;

public class Card : JsonModel
{
    [JsonPropertyName("class")]
    public string Class { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("rank")]
    [JsonConverter(typeof(NumberToStringConverter))]
    public string Rank { get; set; }

    [JsonPropertyName("short")]
    [JsonConverter(typeof(NumberToStringConverter))]
    public string Short { get; set; }
}