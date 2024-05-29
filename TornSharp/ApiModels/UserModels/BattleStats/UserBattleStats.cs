using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.BattleStats;

public class UserBattleStats : JsonModel, IUserStatistics
{
    [JsonPropertyName("defense")]
    public int Defense { get; set; }

    [JsonPropertyName("defense_info")]
    public List<string> DefenseInfo { get; set; }

    [JsonPropertyName("defense_modifier")]
    public int DefenseModifier { get; set; }

    [JsonPropertyName("dexterity")]
    public int Dexterity { get; set; }

    [JsonPropertyName("dexterity_info")]
    public List<string> DexterityInfo { get; set; }

    [JsonPropertyName("dexterity_modifier")]
    public int DexterityModifier { get; set; }

    [JsonPropertyName("speed")]
    public int Speed { get; set; }

    [JsonPropertyName("speed_info")]
    public List<string> SpeedInfo { get; set; }

    [JsonPropertyName("speed_modifier")]
    public int SpeedModifier { get; set; }

    [JsonPropertyName("strength")]
    public int Strength { get; set; }

    [JsonPropertyName("strength_info")]
    public List<string> StrengthInfo { get; set; }

    [JsonPropertyName("strength_modifier")]
    public int StrengthModifier { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }

    public string GetMethodName()
    {
        return UserMethods.battlestats.ToString();
    }
}