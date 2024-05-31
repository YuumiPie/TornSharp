using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.CompanyModels.Detailed;

public class CompanyDetailed : JsonModel, ICompanyStats
{
    [JsonPropertyName("advertising_budget")]
    public int AdvertisingBudget { get; set; }

    [JsonPropertyName("company_bank")]
    public int CompanyBank { get; set; }

    [JsonPropertyName("company_funds")]
    public int CompanyFunds { get; set; }

    [JsonPropertyName("efficiency")]
    public int Efficiency { get; set; }

    [JsonPropertyName("environment")]
    public int Environment { get; set; }

    [JsonPropertyName("ID")]
    public int Id { get; set; }

    [JsonPropertyName("popularity")]
    public int Popularity { get; set; }

    [JsonPropertyName("trains_available")]
    public int TrainsAvailable { get; set; }

    [JsonPropertyName("upgrades")]
    public Upgrades Upgrades { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }

    public string GetMethodName()
    {
        return CompanyMethods.detailed.ToString();
    }
}