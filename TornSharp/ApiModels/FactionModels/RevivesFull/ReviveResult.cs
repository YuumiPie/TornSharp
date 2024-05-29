using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.RevivesFull;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ReviveResult
{
    failure,
    success
}