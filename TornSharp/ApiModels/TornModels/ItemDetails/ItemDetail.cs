using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.ItemDetails;

public class ItemDetail : JsonModel
{
    [JsonPropertyName("accuracy")]
    public double? Accuracy { get; set; }

    [JsonPropertyName("armor")]
    public double? Armor { get; set; }

    [JsonPropertyName("bonuses")]
    public Dictionary<int, Bonus>? Bonuses { get; set; }

    [JsonPropertyName("damage")]
    public double? Damage { get; set; }

    [JsonPropertyName("ID")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("quality")]
    public double Quality { get; set; }

    [JsonPropertyName("rarity")]
    public Rarity Rarity { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("UID")]
    public long Uid { get; set; }
}