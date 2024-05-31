using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Properties;

public class Rented : JsonModel
{
    [JsonPropertyName("cost_per_day")]
    public int CostPerDay { get; set; }

    [JsonPropertyName("days_left")]
    public int DaysLeft { get; set; }

    [JsonPropertyName("total_cost")]
    public int TotalCost { get; set; }

    [JsonPropertyName("user_id")]
    public int UserId { get; set; }
}