using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Basic;

public class Ranking : JsonModel
{
    [JsonPropertyName("division")]
    public int Division { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("name")]
    public Rank Name { get; set; }

    [JsonPropertyName("position")]
    public int Position { get; set; }

    [JsonPropertyName("wins")]
    public int Wins { get; set; }
}