using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Missions;

public class UserMissions : JsonModel, IUserStatistics
{
    [JsonPropertyName("Duke")]
    public List<Mission> Duke { get; set; }

    public string GetMethodName()
    {
        return UserMethods.missions.ToString();
    }
}