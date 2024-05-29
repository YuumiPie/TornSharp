using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Basic;

public class Member : JsonModel
{
    [JsonPropertyName("days_in_faction")]
    public int DaysInFaction { get; set; }

    [JsonPropertyName("last_action")]
    public LastAction LastAction { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("position")]
    public string Position { get; set; }

    [JsonPropertyName("status")]
    public Status Status { get; set; }
}