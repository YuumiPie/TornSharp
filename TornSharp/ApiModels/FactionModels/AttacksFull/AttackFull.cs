using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.FactionModels.AttacksFull;

public class AttackFull : JsonModel
{
    [JsonPropertyName("attacker_faction")]
    public string AttackerFaction { get; set; }

    [JsonPropertyName("attacker_id")]
    public string AttackerId { get; set; }

    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("defender_faction")]
    public int DefenderFaction { get; set; }

    [JsonPropertyName("defender_id")]
    public int DefenderId { get; set; }

    [JsonPropertyName("respect")]
    public double Respect { get; set; }

    [JsonPropertyName("result")]
    public AttackResult Result { get; set; }

    [JsonPropertyName("stealthed")]
    [JsonConverter(typeof(BoolConverter))]
    public bool Stealthed { get; set; }

    [JsonPropertyName("timestamp_ended")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public double TimestampEnded { get; set; }

    [JsonPropertyName("timestamp_started")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public double TimestampStarted { get; set; }
}