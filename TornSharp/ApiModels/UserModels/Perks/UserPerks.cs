using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Perks;

public class UserPerks : JsonModel, IUserStats
{
    [JsonPropertyName("job_perks")]
    public List<string> JobPerks { get; set; }

    [JsonPropertyName("property_perks")]
    public List<string> PropertyPerks { get; set; }

    [JsonPropertyName("stock_perks")]
    public List<string> StockPerks { get; set; }

    [JsonPropertyName("merit_perks")]
    public List<string> MeritPerks { get; set; }

    [JsonPropertyName("education_perks")]
    public List<string> EducationPerks { get; set; }

    [JsonPropertyName("enhancer_perks")]
    public List<string> EnhancerPerks { get; set; }

    [JsonPropertyName("company_perks")]
    public List<string> CompanyPerks { get; set; }

    [JsonPropertyName("faction_perks")]
    public List<string> FactionPerks { get; set; }

    public string GetMethodName()
    {
        return UserMethods.perks.ToString();
    }
}