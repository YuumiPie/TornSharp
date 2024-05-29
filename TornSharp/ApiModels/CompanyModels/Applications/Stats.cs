using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.CompanyModels.Applications;

public class Stats : JsonModel
{
    [JsonPropertyName("endurance")]
    public int Endurance { get; set; }

    [JsonPropertyName("intelligence")]
    public int Intelligence { get; set; }

    [JsonPropertyName("manual_labor")]
    public int ManualLabor { get; set; }
}