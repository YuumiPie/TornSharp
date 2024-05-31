using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.JobPoints;

public class UserJobPoints : JsonModel, IUserStats
{
    [JsonPropertyName("jobpoints")]
    public JobPoints JobPoints { get; set; }

    public string GetMethodName()
    {
        return UserMethods.jobpoints.ToString();
    }
}