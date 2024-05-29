using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Refills;

public class Refills : JsonModel
{
    [JsonPropertyName("energy_refill_used")]
    public bool EnergyRefillUsed { get; set; }

    [JsonPropertyName("nerve_refill_used")]
    public bool NerveRefillUsed { get; set; }

    [JsonPropertyName("special_refills_available")]
    public int SpecialRefillsAvailable { get; set; }

    [JsonPropertyName("token_refill_used")]
    public bool TokenRefillUsed { get; set; }
}