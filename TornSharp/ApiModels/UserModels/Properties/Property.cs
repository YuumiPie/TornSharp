using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Properties;

public class Property : JsonModel
{
    [JsonPropertyName("cost")]
    public int Cost { get; set; }

    [JsonPropertyName("happy")]
    public int Happy { get; set; }

    [JsonPropertyName("marketprice")]
    public int MarketPrice { get; set; }

    [JsonPropertyName("modifications")]
    public Modifications Modifications { get; set; }

    [JsonPropertyName("owner_id")]
    public int OwnerId { get; set; }

    [JsonPropertyName("property")]
    public string PropertyId { get; set; }

    [JsonPropertyName("property_type")]
    public int PropertyType { get; set; }

    [JsonPropertyName("rented")]
    public Rented? Rented { get; set; }

    [JsonPropertyName("staff")]
    public Staff Staff { get; set; }

    [JsonPropertyName("staff_cost")]
    public int StaffCost { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("upkeep")]
    public int Upkeep { get; set; }
}