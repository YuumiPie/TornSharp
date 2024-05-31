using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.CompanyModels.Employees;

public class CompanyEmployees : JsonModel, ICompanyStats
{
    [JsonPropertyName("company_employees")]
    public Dictionary<int, Employee> Employees { get; set; }

    public string GetMethodName()
    {
        return CompanyMethods.employees.ToString();
    }
}