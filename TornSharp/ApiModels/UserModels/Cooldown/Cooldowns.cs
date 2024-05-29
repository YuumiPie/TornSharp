using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Cooldown;

public class Cooldowns : JsonModel
{
    [JsonPropertyName("booster")]
    public int Booster { get; set; }

    [JsonPropertyName("drug")]
    public int Drug { get; set; }

    [JsonPropertyName("medical")]
    public int Medical { get; set; }
}