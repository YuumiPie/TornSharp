using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.PokerTables;

public class PokerTable : JsonModel
{
    [JsonPropertyName("big_blind")]
    public int BigBlind { get; set; }

    [JsonPropertyName("current_players")]
    public int CurrentPlayers { get; set; }

    [JsonPropertyName("maximum_players")]
    public int MaximumPlayers { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("small_blind")]
    public int SmallBlind { get; set; }

    [JsonPropertyName("speed")]
    public int Speed { get; set; }
}