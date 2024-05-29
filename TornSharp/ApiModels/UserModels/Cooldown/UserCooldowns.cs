using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Cooldown;

public class UserCooldowns : JsonModel, IUserStatistics
{
    [JsonPropertyName("cooldowns")]
    public Cooldowns Cooldowns { get; set; }

    public string GetMethodName()
    {
        return UserMethods.cooldowns.ToString();
    }
}