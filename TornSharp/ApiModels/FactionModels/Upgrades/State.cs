using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Upgrades;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum State
{
    [EnumMember(Value = "peace")]
    Peace,
    [EnumMember(Value = "war")]
    War
}