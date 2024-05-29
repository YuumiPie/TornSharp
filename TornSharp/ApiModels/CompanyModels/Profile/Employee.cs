using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.CompanyModels.Profile;

public class Employee : JsonModel
{
    [JsonPropertyName("days_in_company")]
    public int DayInCompany { get; set; }

    [JsonPropertyName("last_action")]
    public LastAction LastAction { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("position")]
    public string Position { get; set; }

    [JsonPropertyName("status")]
    public Status Status { get; set; }
}