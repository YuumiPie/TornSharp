using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.RankedWarReport;

public class Item : JsonModel
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("quantity")]
    public int Quanitity { get; set; }
}