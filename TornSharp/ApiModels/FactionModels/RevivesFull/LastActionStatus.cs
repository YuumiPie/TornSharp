using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.RevivesFull;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum LastActionStatus
{
    Idle,
    Offline,
    Online
}