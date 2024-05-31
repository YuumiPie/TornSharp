using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.JobPoints;

public class UserJobPoints : JsonModel, IUserStats
{
    [JsonPropertyName("companies")]
    public Dictionary<int, CompanyPoints> Companies { get; set; }

    [JsonPropertyName("jobs")]
    public Jobs Jobs { get; set; }

    public string GetMethodName()
    {
        return UserMethods.jobpoints.ToString();
    }
}