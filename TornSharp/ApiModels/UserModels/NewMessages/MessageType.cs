using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.NewMessages;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum MessageType
{
    [EnumMember(Value = "Company Newsletter")]
    CompanyNewsletter,
    [EnumMember(Value = "Faction Newsletter")]
    FactionNewsletter,
    [EnumMember(Value = "User Message")]
    UserMessage,
}