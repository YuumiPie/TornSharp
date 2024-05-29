using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Reports;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ReportType
{
    [EnumMember(Value = "anonymousbounties")]
    AnonymousBounties,
    [EnumMember(Value = "friendorfoe")]
    FriendOrFoe,
    [EnumMember(Value = "investment")]
    Investment,
    [EnumMember(Value = "money")]
    Money,
    [EnumMember(Value = "mostwanted")]
    MostWanted,
    [EnumMember(Value = "references")]
    References,
    [EnumMember(Value = "stats")]
    Stats,
    [EnumMember(Value = "truelevel")]
    TrueLevel
}