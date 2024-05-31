using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Items;

public class Item : JsonModel
{
    [JsonPropertyName("buy_price")]
    public long BuyPrice { get; set; }

    [JsonPropertyName("circulation")]
    public long Circulation { get; set; }

    [JsonPropertyName("coverage")]
    public Coverage? Coverage { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("effect")]
    public string Effect { get; set; }

    [JsonPropertyName("image")]
    public string Image { get; set; }

    [JsonPropertyName("market_value")]
    public long MarketValue { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("requirement")]
    public string Requirement { get; set; }

    [JsonPropertyName("sell_price")]
    public int SellPrice { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("weapon_type")]
    public string? WeaponType { get; set; }
}