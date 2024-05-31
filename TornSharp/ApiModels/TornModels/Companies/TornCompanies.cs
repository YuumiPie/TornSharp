using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Companies;

public class TornCompanies : JsonModel, ITornStats
{
    [JsonPropertyName("companies")]
    public Dictionary<int, Company> Companies { get; set; }

    public string GetMethodName()
    {
        return TornMethods.companies.ToString();
    }
}