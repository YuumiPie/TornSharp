using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Donations;

public class Donation : JsonModel
{
    [JsonPropertyName("money_balance")]
    public int MoneyBalance { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("points_balance")]
    public int PointsBalance { get; set; }
}