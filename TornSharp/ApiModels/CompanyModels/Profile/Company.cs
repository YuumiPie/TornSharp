using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.CompanyModels.Profile;

public class Company : JsonModel
{
    [JsonPropertyName("company_type")]
    public int CompanyType { get; set; }

    [JsonPropertyName("daily_customers")]
    public int DailyCustomers { get; set; }

    [JsonPropertyName("daily_income")]
    public int DailyIncome { get; set; }

    [JsonPropertyName("days_old")]
    public int DaysOld { get; set; }

    [JsonPropertyName("director")]
    public int Director { get; set; }

    [JsonPropertyName("employees")]
    public Dictionary<int, Employee> Employees { get; set; }

    [JsonPropertyName("employees_capacity")]
    public int EmployeesCapacity { get; set; }

    [JsonPropertyName("employees_hired")]
    public int EmployeesHired { get; set; }

    [JsonPropertyName("ID")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("rating")]
    public int Rating { get; set; }

    [JsonPropertyName("weekly_customers")]
    public int WeeklyCustomers { get; set; }

    [JsonPropertyName("weekly_income")]
    public int WeeklyIncome { get; set; }
}