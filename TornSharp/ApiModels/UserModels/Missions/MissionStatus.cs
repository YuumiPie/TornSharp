using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Missions;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum MissionStatus
{
    [EnumMember(Value = "accepted")]
    Accepted,
    [EnumMember(Value = "completed")]
    Completed,
    [EnumMember(Value = "failed")]
    Dailed,
    [EnumMember(Value = "notAccepted")]
    NotAccepted,
}