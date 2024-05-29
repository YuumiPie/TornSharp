using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.CompanyModels.Employees;

public class Employee : JsonModel
{
    [JsonPropertyName("days_in_company")]
    public int DayInCompany { get; set; }

    [JsonPropertyName("effectiveness")]
    public Effectiveness? Effectiveness { get; set; }

    [JsonPropertyName("endurance")]
    public int? Endurance { get; set; }

    [JsonPropertyName("intelligence")]
    public int? Intelligence { get; set; }

    [JsonPropertyName("last_action")]
    public LastAction LastAction { get; set; }

    [JsonPropertyName("manual_labor")]
    public int? ManualLabor { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("position")]
    public string Position { get; set; }

    [JsonPropertyName("status")]
    public Status Status { get; set; }

    [JsonPropertyName("wage")]
    public int? Wage { get; set; }
}