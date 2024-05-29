using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.FactionModels.Crimes;

public class Crime : JsonModel
{
    [JsonPropertyName("crime_id")]
    public int CrimeId { get; set; }

    [JsonPropertyName("crime_name")]
    public string CrimeName { get; set; }

    [JsonPropertyName("initiated")]
    [JsonConverter(typeof(BoolConverter))]
    public bool Initiated { get; set; }

    [JsonPropertyName("initiated_by")]
    public int InitiatedBy { get; set; }

    [JsonPropertyName("money_gain")]
    public int MoneyGain { get; set; }

    [JsonPropertyName("participants")]
    public List<List<KeyValuePair<long?, Status>>> Participants { get; set; }

    [JsonPropertyName("planned_by")]
    public int PlannedBy { get; set; }

    [JsonPropertyName("respect_gain")]
    public int RespectGain { get; set; }

    [JsonPropertyName("success")]
    [JsonConverter(typeof(BoolConverter))]
    public bool Success { get; set; }

    [JsonPropertyName("time_completed")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime TimeCompleted { get; set; }

    [JsonPropertyName("time_left")]
    public int TimeLeft { get; set; }

    [JsonPropertyName("time_ready")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime TimeReady { get; set; }

    [JsonPropertyName("time_started")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime TimeStarted { get; set; }
}