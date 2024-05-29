using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.CityShops;

public class Item : JsonModel
{
    [JsonPropertyName("in_stock")]
    public int InStock { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("price")]
    public int Price { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
}