using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.FactionTree;

public class Level : JsonModel
{
    [JsonPropertyName("ability")]
    public string Ability { get; set; }

    [JsonPropertyName("base_cost")]
    public int BaseCost { get; set; }

    [JsonPropertyName("branch")]
    public Branch Branch { get; set; }

    [JsonPropertyName("challenge")]
    public string Challenge { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}