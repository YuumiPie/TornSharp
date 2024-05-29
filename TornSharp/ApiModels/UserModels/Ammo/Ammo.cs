using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.UserModels.Ammo;

public class Ammo : JsonModel
{
    [JsonPropertyName("ammoID")]
    public int AmmoId { get; set; }

    [JsonPropertyName("equipped")]
    [JsonConverter(typeof(BoolConverter))]
    public bool Equipped { get; set; }

    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }

    [JsonPropertyName("size")]
    public string Size { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("typeID")]
    public int TypeID { get; set; }
}