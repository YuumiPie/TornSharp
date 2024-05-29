using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Drugs;

public class ArmoryItem : JsonModel
{
    [JsonPropertyName("ID")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
}