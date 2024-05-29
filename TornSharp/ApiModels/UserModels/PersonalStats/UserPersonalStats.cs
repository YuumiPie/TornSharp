using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.PersonalStats;

public class UserPersonalStats : JsonModel, IUserStatistics
{
    [JsonPropertyName("personalstats")]
    public PersonalStats PersonalStats { get; set; }

    public string GetMethodName()
    {
        return UserMethods.personalstats.ToString();
    }
}