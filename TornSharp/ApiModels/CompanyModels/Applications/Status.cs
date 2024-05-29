using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.CompanyModels.Applications;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Status
{
    //incomplete values
    [EnumMember(Value = "accepted")]
    Accepted,
    [EnumMember(Value = "active")]
    Active,
    [EnumMember(Value = "declined")]
    Declined,
    [EnumMember(Value = "withdrawn")]
    Withdrawn
}