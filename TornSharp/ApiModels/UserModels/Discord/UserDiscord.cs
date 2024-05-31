using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Discord;

public class UserDiscord : JsonModel, IUserStats
{
    [JsonPropertyName("discord")]
    public Discord Discord { get; set; }

    public string GetMethodName()
    {
        return UserMethods.discord.ToString();
    }
}