using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Gym;

public class UserGym : JsonModel, IUserStatistics
{
    [JsonPropertyName("active_gym")]
    public int ActiveGym { get; set; }

    public string GetMethodName()
    {
        return UserMethods.gym.ToString();
    }
}