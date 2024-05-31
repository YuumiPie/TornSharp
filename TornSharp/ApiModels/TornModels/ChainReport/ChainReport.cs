using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.TornModels.ChainReport;

public class ChainReport : JsonModel
{
    [JsonPropertyName("assists")]
    public int? Assists { get; set; }

    [JsonPropertyName("besthit")]
    public int? BestHit { get; set; }

    [JsonPropertyName("bonuses")]
    public List<BonusHit> Bonuses { get; set; }

    [JsonPropertyName("chain")]
    public int? Chain { get; set; }

    [JsonPropertyName("code")]
    public int? Code { get; set; }

    [JsonPropertyName("draws")]
    public int? Draws { get; set; }

    [JsonPropertyName("end")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime? End { get; set; }

    [JsonPropertyName("error")]
    public string? Error { get; set; }

    [JsonPropertyName("escapes")]
    public int? Escapes { get; set; }

    [JsonPropertyName("factionID")]
    public int? FactionId { get; set; }

    [JsonPropertyName("hospitalize")]
    public int? Hospitalize { get; set; }

    [JsonPropertyName("leave")]
    public int? Leave { get; set; }

    [JsonPropertyName("losses")]
    public int? Losses { get; set; }

    [JsonPropertyName("members")]
    public Dictionary<int, Member> Members { get; set; }

    [JsonPropertyName("mug")]
    public int? Mug { get; set; }

    [JsonPropertyName("overseas")]
    public int? Overseas { get; set; }

    [JsonPropertyName("respect")]
    public double? Respect { get; set; }

    [JsonPropertyName("retaliations")]
    public int? Retaliations { get; set; }

    [JsonPropertyName("start")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime? Start { get; set; }

    [JsonPropertyName("targets")]
    public int? Targets { get; set; }

    [JsonPropertyName("warhits")]
    public int? WarHits { get; set; }
}