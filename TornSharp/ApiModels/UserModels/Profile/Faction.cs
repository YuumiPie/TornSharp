using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Profile;

public class Faction : JsonModel
{
    [JsonPropertyName("days_in_faction")]
    public int DaysInFaction { get; set; }

    [JsonPropertyName("faction_id")]
    public int FactionId { get; set; }

    [JsonPropertyName("faction_name")]
    public string FactionName { get; set; }

    [JsonPropertyName("faction_tag")]
    public string? FactionTag { get; set; }

    [JsonPropertyName("position")]
    public string Position { get; set; }
}