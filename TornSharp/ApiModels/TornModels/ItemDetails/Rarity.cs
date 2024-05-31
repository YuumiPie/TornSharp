using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.ItemDetails;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Rarity
{
    None,
    Orange,
    Red,
    Yellow,
}