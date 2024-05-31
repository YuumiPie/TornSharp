using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Revives;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ReviveResult
{
    [EnumMember(Value = "failure")]
    Failure,
    [EnumMember(Value = "success")]
    Success
}