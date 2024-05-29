using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.TerritoryWarReport;

public class Faction : JsonModel
{
    [JsonPropertyName("clears")]
    public int Clears { get; set; }

    [JsonPropertyName("joins")]
    public int Joins { get; set; }

    [JsonPropertyName("members")]
    public Dictionary<string, User> Members { get; set; }

    [JsonPropertyName("name")]
    public int Name { get; set; }

    [JsonPropertyName("score")]
    public string Score { get; set; }

    [JsonPropertyName("type")]
    public FactionType Type { get; set; }
}