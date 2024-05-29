using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.KeyModels.Info;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AccessType
{
    Custom,
    [EnumMember(Value = "Full Access")]
    FullAccess,
    [EnumMember(Value = "Limited Access")]
    LimitedAccess,
    [EnumMember(Value = "Minimal Access")]
    MinimalAccess,
    [EnumMember(Value = "Public Only")]
    PublicOnly
}