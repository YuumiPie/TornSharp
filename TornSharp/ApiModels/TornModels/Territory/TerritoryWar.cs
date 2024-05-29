using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.TornModels.Territory;

public class TerritoryWar : JsonModel
{
    [JsonPropertyName("assaulting_faction")]
    public int AssaultingFaction { get; set; }

    [JsonPropertyName("defending_faction")]
    public int DefendingFaction { get; set; }

    [JsonPropertyName("ends")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Ends { get; set; }

    [JsonPropertyName("required_score")]
    public int RequiredScore { get; set; }

    [JsonPropertyName("score")]
    public int Score { get; set; }

    [JsonPropertyName("started")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Started { get; set; }

    [JsonPropertyName("territory_war_id")]
    public int TerritoryWarId { get; set; }
}