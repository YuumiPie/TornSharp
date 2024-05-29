using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.RaidReport;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum RaidType
{
    [EnumMember(Value = "aggressor")]
    Aggressor,
    [EnumMember(Value = "defender")]
    Defender
}