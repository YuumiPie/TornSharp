using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.ItemDetails;

public class Bonus : JsonModel
{
    [JsonPropertyName("bonus")]
    public string BonusName { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("value")]
    public int Chance { get; set; }
}