using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.CompanyModels.Employees;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum LastActionStatus
{
    Idle,
    Offline,
    Online
}