using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Attacks;

public class UserAttacks : JsonModel, IUserStats
{
    [JsonPropertyName("attacks")]
    public Dictionary<int, Attack> Attacks { get; set; }

    public string GetMethodName()
    {
        return UserMethods.attacks.ToString();
    }
}