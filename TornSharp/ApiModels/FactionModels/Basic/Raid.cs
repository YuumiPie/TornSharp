using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.FactionModels.Basic;

public class Raid : JsonModel
{
    [JsonPropertyName("defender_score")]
    public int DefenderScore { get; set; }

    [JsonPropertyName("defending_faction")]
    public int DefendingFaction { get; set; }

    [JsonPropertyName("raider_score")]
    public string RaiderScore { get; set; }

    [JsonPropertyName("raiding_faction")]
    public int RaidingFaction { get; set; }

    [JsonPropertyName("start_time")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime War { get; set; }
}