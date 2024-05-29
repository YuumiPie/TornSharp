using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.CityShops;

public class Shop : JsonModel
{
    [JsonPropertyName("inventory")]
    public Dictionary<string, Item>? Inventory { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}