using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.JobPoints;

public class UserJobPoints : JsonModel, IUserStatistics
{
    [JsonPropertyName("companies")]
    public Dictionary<string, CompanyPoints> Companies { get; set; }

    [JsonPropertyName("jobs")]
    public Jobs Jobs { get; set; }

    public string GetMethodName()
    {
        return UserMethods.jobpoints.ToString();
    }
}