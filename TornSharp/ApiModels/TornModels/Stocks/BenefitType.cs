using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Stocks;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BenefitType
{
    [EnumMember(Value = "active")]
    Active,
    [EnumMember(Value = "passive")]
    Passive,
}