using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Upgrades;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Branch
{
    Aggression,
    Core,
    Criminality,
    Excursion,
    Fortitude,
    Steadfast,
    Suppression,
    Toleration,
    Voracity,
}