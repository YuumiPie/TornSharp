using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Weapons;

public class LoanableArmoryItem : JsonModel
{
    [JsonPropertyName("available")]
    public int Available { get; set; }

    [JsonPropertyName("ID")]
    public int Id { get; set; }

    [JsonPropertyName("loaned")]
    public int Loaned { get; set; }

    [JsonPropertyName("loaned_to")]
    public string? LoanedTo { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
}