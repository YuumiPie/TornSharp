using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Cards;

public class Card : JsonModel
{
    [JsonPropertyName("class")]
    public string Class { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("rank")]
    public string Rank { get; set; }

    [JsonPropertyName("short")]
    public string Short { get; set; }
}