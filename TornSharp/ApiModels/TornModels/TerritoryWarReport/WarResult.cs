using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.TerritoryWarReport;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum WarResult
{
    [EnumMember(Value = "end_with_peace_treaty")]
    EndWithPeaceTreaty,
    [EnumMember(Value = "fail_assault")]
    FailAssault,
    [EnumMember(Value = "success_assault")]
    SuccessAssault
}