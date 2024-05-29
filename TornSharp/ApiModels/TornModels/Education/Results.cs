using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Education;

public class Results : JsonModel
{
    [JsonPropertyName("endurance")]
    public List<string>? Endurance { get; set; }

    [JsonPropertyName("intelligence")]
    public List<string>? Intelligence { get; set; }

    [JsonPropertyName("manual_labor")]
    public List<string>? ManualLabor { get; set; }

    [JsonPropertyName("perk")]
    public List<string>? Perk { get; set; }
}