using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.WeaponExp;

public class WeaponExperience : JsonModel
{
    [JsonPropertyName("exp")]
    public int Exp { get; set; }

    [JsonPropertyName("itemID")]
    public int ItemId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}