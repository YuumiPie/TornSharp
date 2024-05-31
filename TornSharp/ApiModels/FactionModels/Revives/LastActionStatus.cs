using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Revives;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum LastActionStatus
{
    Idle,
    Offline,
    Online,
}