using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.FactionTree;

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
    Voracity
}