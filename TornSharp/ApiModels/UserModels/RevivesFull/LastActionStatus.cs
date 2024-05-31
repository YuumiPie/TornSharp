using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.RevivesFull;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum LastActionStatus
{
    Idle,
    Offline,
    Online,
}