using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.TerritoryWarReport;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum FactionType
{
    [EnumMember(Value = "aggressor")]
    Aggressor,
    [EnumMember(Value = "defender")]
    Defender,
}