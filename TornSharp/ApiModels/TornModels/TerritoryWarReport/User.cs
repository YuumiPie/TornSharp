using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.TerritoryWarReport;

public class User : JsonModel
{
    [JsonPropertyName("clears")]
    public double Clears { get; set; }

    [JsonPropertyName("faction_id")]
    public int FactionId { get; set; }

    [JsonPropertyName("joins")]
    public double Joins { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("points")]
    public int Points { get; set; }
}