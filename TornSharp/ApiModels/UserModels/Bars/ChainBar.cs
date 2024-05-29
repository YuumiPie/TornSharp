using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Bars;

public class ChainBar : JsonModel
{
    [JsonPropertyName("cooldown")]
    public int Cooldown { get; set; }

    [JsonPropertyName("current")]
    public int Current { get; set; }

    [JsonPropertyName("maximum")]
    public int Maximum { get; set; }

    [JsonPropertyName("modifier")]
    public double Modifier { get; set; }

    [JsonPropertyName("timeout")]
    public int Timeout { get; set; }
}