using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Medals;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Rarity
{
    Common,
    [EnumMember(Value = "Extremely Rare")]
    ExtremelyRare,
    Limited,
    Rare,
    Uncommon,
    [EnumMember(Value = "Very Common")]
    VeryCommon,
    [EnumMember(Value = "Very Rare")]
    VeryRare,
    [EnumMember(Value = "Unknown Rarity")]
    UnknownRarity,
}