using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.CompanyModels.Employees;

public class Effectiveness : JsonModel
{
    [JsonPropertyName("addiction")]
    public int? Addiction { get; set; }

    [JsonPropertyName("director_education")]
    public int? DirectorEducation { get; set; }

    [JsonPropertyName("inactivity")]
    public int? Inactivity { get; set; }

    [JsonPropertyName("merits")]
    public int? Merits { get; set; }

    [JsonPropertyName("settled_in")]
    public int? SettledIn { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("working_stats")]
    public int WorkingStats { get; set; }
}