using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Missions;

public class UserMissions : JsonModel, IUserStats
{
    [JsonPropertyName("missions")]
    public Missions Missions { get; set; }

    public string GetMethodName()
    {
        return UserMethods.missions.ToString();
    }
}