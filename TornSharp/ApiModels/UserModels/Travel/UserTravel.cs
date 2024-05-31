using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Travel;

public class UserTravel : JsonModel, IUserStats
{
    [JsonPropertyName("travel")]
    public Travel Travel { get; set; }

    public string GetMethodName()
    {
        return UserMethods.travel.ToString();
    }
}