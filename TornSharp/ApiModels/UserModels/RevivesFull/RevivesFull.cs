using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.UserModels.RevivesFull;

public class RevivesFull : JsonModel
{
    [JsonPropertyName("chance")]
    public double Chance { get; set; }

    [JsonPropertyName("result")]
    public ReviveResult Result { get; set; }

    [JsonPropertyName("reviver_faction")]
    public int ReviverFaction { get; set; }

    [JsonPropertyName("reviver_factionname")]
    public string ReviverFactionName { get; set; }

    [JsonPropertyName("reviver_id")]
    public int ReviverId { get; set; }

    [JsonPropertyName("target_early_discharge")]
    [JsonConverter(typeof(BoolConverter))]
    public bool TargetEarlyDischarge { get; set; }

    [JsonPropertyName("target_faction")]
    public int TargetFaction { get; set; }

    [JsonPropertyName("target_hospital_reason")]
    public string TargetHospitalReason { get; set; }

    [JsonPropertyName("target_id")]
    public int TargetId { get; set; }

    [JsonPropertyName("target_last_action")]
    public ReviveLastAction TargetLastAction { get; set; }

    [JsonPropertyName("timestamp")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Timestamp { get; set; }
}