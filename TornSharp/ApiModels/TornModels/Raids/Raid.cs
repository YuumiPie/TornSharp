using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.TornModels.Raids;

public class Raid : JsonModel
{
    [JsonPropertyName("assaulting_faction")]
    public int AssultingFaction { get; set; }

    [JsonPropertyName("assaulting_score")]
    public double AssultingScore { get; set; }

    [JsonPropertyName("defending_faction")]
    public int DefendingFaction { get; set; }

    [JsonPropertyName("defending_score")]
    public double DefendingScore { get; set; }

    [JsonPropertyName("started")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Attacks { get; set; }
}