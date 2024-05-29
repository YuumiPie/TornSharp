using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.CompanyModels.Lookup;

public class CompanyLookup : JsonModel, ICompanyStatistics
{
    [JsonPropertyName("selections")]
    public List<string> Selections { get; set; }

    public string GetMethodName()
    {
        return CompanyMethods.lookup.ToString();
    }
}