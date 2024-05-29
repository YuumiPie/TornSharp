using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.TornModels.ItemStats;

public class Stats : JsonModel
{
    [JsonPropertyName("critical_hits")]
    public int? CriticalHits { get; set; }

    [JsonPropertyName("damage")]
    public int? Damage { get; set; }

    [JsonPropertyName("damage_mitigated")]
    public double? DamageMitigated { get; set; }

    [JsonPropertyName("damage_taken")]
    public double? DamageTaken { get; set; }

    [JsonPropertyName("finishing_hits")]
    public int? FinsihingHits { get; set; }

    [JsonPropertyName("first_faction_owner")]
    public int? FirstFactionOwner { get; set; }

    [JsonPropertyName("first_owner")]
    public int? FirstOwner { get; set; }

    [JsonPropertyName("highest_damage")]
    public int? HighestDamage { get; set; }

    [JsonPropertyName("hits")]
    public int? Hits { get; set; }

    [JsonPropertyName("hits_received")]
    public double? HitsReceived { get; set; }

    [JsonPropertyName("misses")]
    public int? Misses { get; set; }

    [JsonPropertyName("most_damage_mitigated")]
    public double? MostDamageMitigated { get; set; }

    [JsonPropertyName("most_damage_taken")]
    public double? MostDamageTaken { get; set; }

    [JsonPropertyName("reloads")]
    public int? Reloads { get; set; }

    [JsonPropertyName("respect_earned")]
    public double? RespectEarned { get; set; }

    [JsonPropertyName("rounds_fired")]
    public int? RoundsFired { get; set; }

    [JsonPropertyName("time_created")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime BuyPrice { get; set; }
}