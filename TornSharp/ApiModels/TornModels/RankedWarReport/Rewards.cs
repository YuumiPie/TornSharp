using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.RankedWarReport;

public class Rewards : JsonModel
{
    [JsonPropertyName("items")]
    public Dictionary<int, Item> Items { get; set; }

    [JsonPropertyName("points")]
    public int Points { get; set; }

    [JsonPropertyName("respect")]
    public int Respect { get; set; }
}