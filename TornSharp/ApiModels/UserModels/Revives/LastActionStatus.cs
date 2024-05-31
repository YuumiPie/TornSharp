using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Revives;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum LastActionStatus
{
    Idle,
    Offline,
    Online,
}