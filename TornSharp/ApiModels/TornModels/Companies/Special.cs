using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Companies;

public class Special : JsonModel
{
    [JsonPropertyName("cost")]
    public int Cost { get; set; }

    [JsonPropertyName("effect")]
    public string Effect { get; set; }

    [JsonPropertyName("rating_required")]
    public int RatingRequired { get; set; }
}