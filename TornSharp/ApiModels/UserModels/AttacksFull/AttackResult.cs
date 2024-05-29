using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.AttacksFull;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AttackResult
{
    Arrested,
    Assist,
    Attacked,
    Escape,
    Hospitalized,
    Interrupted,
    Looted,
    Lost,
    Mugged,
    Special,
    Stalemate,
    Timeout,
}