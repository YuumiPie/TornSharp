using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.CompanyModels.Companies;

public class CompanyCompanies : JsonModel, ICompanyStatistics
{
    [JsonPropertyName("cards")]
    public Dictionary<int, Company> Companies { get; set; }

    public string GetMethodName()
    {
        return CompanyMethods.companies.ToString();
    }
}