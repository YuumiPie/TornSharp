using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Bank;

public class Bank : JsonModel
{
    [JsonPropertyName("1m")]
    public double OneMonth { get; set; }

    [JsonPropertyName("1w")]
    public double OneWeek { get; set; }

    [JsonPropertyName("2m")]
    public double TwoMonths { get; set; }

    [JsonPropertyName("2w")]
    public double TwoWeeks { get; set; }

    [JsonPropertyName("3m")]
    public double ThreeMonths { get; set; }
}