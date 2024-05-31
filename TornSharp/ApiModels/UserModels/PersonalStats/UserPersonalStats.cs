using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.PersonalStats;

public class UserPersonalStats : JsonModel, IUserStats
{
    [JsonPropertyName("personalstats")]
    public PersonalStats PersonalStats { get; set; }

    public string GetMethodName()
    {
        return UserMethods.personalstats.ToString();
    }
}