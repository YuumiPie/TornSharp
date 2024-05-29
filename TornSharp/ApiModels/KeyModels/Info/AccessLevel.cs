using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.KeyModels.Info;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AccessLevel
{
    [EnumMember(Value = "0")]
    Zero,
    [EnumMember(Value = "1")]
    One,
    [EnumMember(Value = "2")]
    Two,
    [EnumMember(Value = "3")]
    Three,
    [EnumMember(Value = "4")]
    Four
}