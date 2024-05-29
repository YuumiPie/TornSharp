using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.FactionModels.Basic;

public class TerritoryWar : JsonModel
{
    [JsonPropertyName("assaulting_faction")]
    public int AssaultingFaction { get; set; }

    [JsonPropertyName("defending_faction")]
    public int DefendingFaction { get; set; }

    [JsonPropertyName("end_time")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime EndTime { get; set; }

    [JsonPropertyName("required_score")]
    public int RequiredScore { get; set; }

    [JsonPropertyName("score")]
    public int Score { get; set; }

    [JsonPropertyName("start_time")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime StartTime { get; set; }

    [JsonPropertyName("territory")]
    public string Territory { get; set; }

    [JsonPropertyName("territory_war_id")]
    public int TerritoryWarId { get; set; }
}