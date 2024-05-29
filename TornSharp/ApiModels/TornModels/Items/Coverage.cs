using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Items;

public class Coverage : JsonModel
{
    [JsonPropertyName("Arm Coverage")]
    public double ArmCoverage { get; set; }

    [JsonPropertyName("Chest Coverage")]
    public double ChestCoverage { get; set; }

    [JsonPropertyName("Foot Coverage")]
    public double FootCoverage { get; set; }

    [JsonPropertyName("Full Body Coverage")]
    public double FullBodyCoverage { get; set; }

    [JsonPropertyName("Groin Coverage")]
    public double GroinCoverage { get; set; }

    [JsonPropertyName("Hand Coverage")]
    public double HandCoverage { get; set; }

    [JsonPropertyName("Head Coverage")]
    public double HeadCoverage { get; set; }

    [JsonPropertyName("Heart Coverage")]
    public double HeartCoverage { get; set; }

    [JsonPropertyName("Leg Coverage")]
    public double LegCoverage { get; set; }

    [JsonPropertyName("Stomach Coverage")]
    public double StomachCoverage { get; set; }

    [JsonPropertyName("Throat Coverage")]
    public double ThroatCoverage { get; set; }
}