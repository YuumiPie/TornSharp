using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.PawnShop;

public class PawnShop : JsonModel
{
    [JsonPropertyName("donatorpack_value")]
    public int DonaterPackValue { get; set; }

    [JsonPropertyName("points_value")]
    public int PointsValue { get; set; }
}