using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.ChainReport;

public class BonusHit : JsonModel
{
    [JsonPropertyName("attacker")]
    public int Attacker { get; set; }

    [JsonPropertyName("chain")]
    public int Chain { get; set; }

    [JsonPropertyName("defender")]
    public int Defender { get; set; }

    [JsonPropertyName("respect")]
    public int Respect { get; set; }
}