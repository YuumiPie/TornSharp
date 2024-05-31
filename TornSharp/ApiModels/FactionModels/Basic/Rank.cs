using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Basic;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Rank
{
    Bronze,
    Diamond,
    Gold,
    Platinum,
    Silver,
    Unranked,
}