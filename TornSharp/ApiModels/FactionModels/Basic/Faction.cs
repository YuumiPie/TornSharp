using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Basic;

public class Faction : JsonModel
{
    [JsonPropertyName("chain")]
    public int Chain { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("score")]
    public int Score { get; set; }
}