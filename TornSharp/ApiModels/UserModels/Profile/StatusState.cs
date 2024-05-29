using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Profile;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum StatusState
{
    Abroad,
    Fallen,
    Federal,
    Hospital,
    Jail,
    Okay,
    Traveling,
}