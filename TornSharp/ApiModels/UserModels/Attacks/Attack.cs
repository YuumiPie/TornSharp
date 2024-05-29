using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.UserModels.Attacks;

public class Attack : JsonModel
{
    [JsonPropertyName("attacker_faction")]
    public int? AttackerFaction { get; set; }

    [JsonPropertyName("attacker_factionname")]
    public string AttackerFactionName { get; set; }

    [JsonPropertyName("attacker_id")]
    public int? AttackerId { get; set; }

    [JsonPropertyName("attacker_name")]
    public string AttackerName { get; set; }

    [JsonPropertyName("chain")]
    public int Chain { get; set; }

    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("defender_faction")]
    public int DefenderFaction { get; set; }

    [JsonPropertyName("defender_factionname")]
    public string DefenderFactionName { get; set; }

    [JsonPropertyName("defender_id")]
    public int DefenderId { get; set; }

    [JsonPropertyName("defender_name")]
    public string DefenderName { get; set; }

    [JsonPropertyName("modifiers")]
    public Modifiers Modifiers { get; set; }

    [JsonPropertyName("raid")]
    [JsonConverter(typeof(BoolConverter))]
    public bool Raid { get; set; }

    [JsonPropertyName("ranked_war")]
    [JsonConverter(typeof(BoolConverter))]
    public bool RankedWar { get; set; }

    [JsonPropertyName("respect")]
    public double Respect { get; set; }

    [JsonPropertyName("respect_gain")]
    public double RespectGain { get; set; }

    [JsonPropertyName("respect_loss")]
    public double RespectLoss { get; set; }

    [JsonPropertyName("result")]
    public AttackResult Result { get; set; }

    [JsonPropertyName("stealthed")]
    [JsonConverter(typeof(BoolConverter))]
    public bool Stealthed { get; set; }

    [JsonPropertyName("timestamp_ended")]
    public int TimestampEnded { get; set; }

    [JsonPropertyName("timestamp_started")]
    public int TimestampStarted { get; set; }
}