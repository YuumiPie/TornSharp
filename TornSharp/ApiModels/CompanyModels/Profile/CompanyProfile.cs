using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.CompanyModels.Profile;

public class CompanyProfile : JsonModel, ICompanyStatistics
{
    [JsonPropertyName("company")]
    public Company Company { get; set; }

    public string GetMethodName()
    {
        return CompanyMethods.profile.ToString();
    }
}