using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Honors;

public class Honor : JsonModel
{
    [JsonPropertyName("circulation")]
    public int? Circulation { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("equipped")]
    public string? Equipped { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("rarity")]
    public Rarity? Rarity { get; set; }

    [JsonPropertyName("type")]
    public int Type { get; set; }
}