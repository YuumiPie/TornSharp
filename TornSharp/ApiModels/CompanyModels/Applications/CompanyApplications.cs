using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.CompanyModels.Applications;

public class CompanyApplications : JsonModel, ICompanyStats
{
    [JsonPropertyName("applications")]
    public Dictionary<int, Application> Applications { get; set; }

    public string GetMethodName()
    {
        return CompanyMethods.applications.ToString();
    }
}