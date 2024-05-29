using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Honors;

public class UserHonors : JsonModel, IUserStatistics
{
    [JsonPropertyName("honors_awarded")]
    public List<int> HonorsAwarded { get; set; }

    [JsonPropertyName("honors_time")]
    public List<int> HonorsTime { get; set; }

    public string GetMethodName()
    {
        return UserMethods.honors.ToString();
    }
}