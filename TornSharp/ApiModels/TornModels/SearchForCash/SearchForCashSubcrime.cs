using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.SearchForCash;

public class SearchForCashSubcrime : JsonModel
{
    [JsonPropertyName("percentage")]
    public double Percentage { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }
}