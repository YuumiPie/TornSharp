using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Stocks;

public class Price : JsonModel
{
    [JsonPropertyName("change")]
    public double Change { get; set; }

    [JsonPropertyName("change_percentage")]
    public double ChangePercentage { get; set; }

    [JsonPropertyName("end")]
    public double End { get; set; }

    [JsonPropertyName("high")]
    public double High { get; set; }

    [JsonPropertyName("low")]
    public double Low { get; set; }

    [JsonPropertyName("start")]
    public double Start { get; set; }
}