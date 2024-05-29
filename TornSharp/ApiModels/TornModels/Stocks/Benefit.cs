using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Stocks;

public class Benefit : JsonModel
{
    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("frequency")]
    public int Frequency { get; set; }

    [JsonPropertyName("requirement")]
    public int Requirement { get; set; }

    [JsonPropertyName("type")]
    public BenefitType Type { get; set; }
}