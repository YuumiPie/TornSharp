using System.Runtime.Serialization;

namespace TornSharp.Enums;

public enum Fields
{
    [EnumMember(Value = "user")]
    User,
    [EnumMember(Value = "property")]
    Property,
    [EnumMember(Value = "faction")]
    Faction,
    [EnumMember(Value = "company")]
    Company,
    [EnumMember(Value = "market")]
    Market,
    [EnumMember(Value = "torn")]
    Torn,
    [EnumMember(Value = "key")]
    Key,
}