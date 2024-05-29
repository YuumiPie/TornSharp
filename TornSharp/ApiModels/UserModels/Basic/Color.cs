using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Basic;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Color
{
    [EnumMember(Value = "blue")]
    Blue,
    [EnumMember(Value = "green")]
    Green,
    [EnumMember(Value = "red")]
    Red,
}