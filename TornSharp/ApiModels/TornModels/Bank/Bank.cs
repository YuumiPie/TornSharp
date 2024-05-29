using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Bank;

public class Bank : JsonModel
{
    [JsonPropertyName("1m")]
    public int OneMonth { get; set; }

    [JsonPropertyName("1w")]
    public int OneWeek { get; set; }

    [JsonPropertyName("2m")]
    public int TwoMonths { get; set; }

    [JsonPropertyName("2w")]
    public int TwoWeeks { get; set; }

    [JsonPropertyName("3m")]
    public int ThreeMonths { get; set; }
}