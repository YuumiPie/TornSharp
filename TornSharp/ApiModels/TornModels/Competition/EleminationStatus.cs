using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Competition;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum EleminationStatus
{
    //one unknown
    [EnumMember(Value = "before-eliminated")]
    BeforeEliminated,
    [EnumMember(Value = "eliminated")]
    Eliminated,
}