using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Attacks;

public class Modifiers : JsonModel
{
    [JsonPropertyName("chain_bonus")]
    public double ChainBonus { get; set; }

    [JsonPropertyName("fair_fight")]
    public double FairFight { get; set; }

    [JsonPropertyName("group_attack")]
    public double GroupAttack { get; set; }

    [JsonPropertyName("overseas")]
    public double Overseas { get; set; }

    [JsonPropertyName("retaliation")]
    public double Retaliation { get; set; }

    [JsonPropertyName("war")]
    public int War { get; set; }

    [JsonPropertyName("warlord_bonus")]
    public string? WarlordBonus { get; set; }
}