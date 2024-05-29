using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.OrganizedCrimes;

public class OrganizedCrime : JsonModel
{
    [JsonPropertyName("max_cash")]
    public int MaxCash { get; set; }

    [JsonPropertyName("max_respect")]
    public int MaxRespect { get; set; }

    [JsonPropertyName("members")]
    public int Members { get; set; }

    [JsonPropertyName("min_cash")]
    public int MinCash { get; set; }

    [JsonPropertyName("min_respect")]
    public int MinRespect { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("time")]
    public int Time { get; set; }
}