using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.CompanyModels.Profile;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum LastActionStatus
{
    Idle,
    Offline,
    Online
}