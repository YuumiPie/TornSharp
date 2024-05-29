using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.CompanyModels.Employees;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum StatusColor
{
    [EnumMember(Value = "blue")]
    Blue,
    [EnumMember(Value = "green")]
    Green,
    [EnumMember(Value = "red")]
    Red
}