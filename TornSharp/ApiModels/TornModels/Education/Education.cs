using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Education;

public class Education : JsonModel
{
    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("duration")]
    public int Duration { get; set; }

    [JsonPropertyName("money_cost")]
    public int MoneyCost { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("prerequisites")]
    public List<int> Prerquisites { get; set; }

    [JsonPropertyName("results")]
    public Results Results { get; set; }

    [JsonPropertyName("tier")]
    public int Tier { get; set; }
}