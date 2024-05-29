using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.UserModels.AttacksFull;

public class AttackFull : JsonModel
{
    [JsonPropertyName("attacker_faction")]
    public int? AttackerFaction { get; set; }

    [JsonPropertyName("attacker_id")]
    public int? AttackerId { get; set; }

    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("defender_faction")]
    public int DefenderFaction { get; set; }

    [JsonPropertyName("defender_id")]
    public int DefenderId { get; set; }

    [JsonPropertyName("respect")]
    public double Respect { get; set; }

    [JsonPropertyName("result")]
    public Attacks.AttackResult Result { get; set; }

    [JsonPropertyName("stealthed")]
    [JsonConverter(typeof(BoolConverter))]
    public bool Stealthed { get; set; }

    [JsonPropertyName("timestamp_ended")]
    public int TimestampEnded { get; set; }

    [JsonPropertyName("timestamp_started")]
    public int TimestampStarted { get; set; }
}