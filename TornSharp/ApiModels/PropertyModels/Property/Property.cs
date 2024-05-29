using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.PropertyModels.Property;

public class Property : JsonModel
{
    [JsonPropertyName("happy")]
    public int Happy { get; set; }

    [JsonPropertyName("owner_id")]
    public int OwnerId { get; set; }

    [JsonPropertyName("property_type")]
    public int PropertyType { get; set; }

    [JsonPropertyName("rented")]
    public Rented? Rented { get; set; }

    [JsonPropertyName("staff")]
    public List<string> Staff { get; set; }

    [JsonPropertyName("upgrades")]
    public List<string> Upgrades { get; set; }

    [JsonPropertyName("upkeep")]
    public int Upkeep { get; set; }

    [JsonPropertyName("users_living")]
    public string? UsersLiving { get; set; }
}