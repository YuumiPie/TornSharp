using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Basic;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum LastActionStatus
{
    Idle,
    Offline,
    Online
}