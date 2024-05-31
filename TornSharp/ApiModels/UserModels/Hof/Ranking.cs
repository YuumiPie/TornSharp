using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Hof;

public class Ranking : JsonModel
{
    [JsonPropertyName("rank")]
    public int Rank { get; set; }

    [JsonPropertyName("value")]
    public long Value { get; set; }
}