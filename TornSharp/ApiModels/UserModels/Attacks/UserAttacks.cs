using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Attacks;

public class UserAttacks : JsonModel, IUserStatistics
{
    [JsonPropertyName("attacks")]
    public Dictionary<string, Attack> Attacks { get; set; }

    public string GetMethodName()
    {
        return UserMethods.attacks.ToString();
    }
}