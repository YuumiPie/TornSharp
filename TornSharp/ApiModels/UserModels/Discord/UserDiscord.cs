using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Discord;

public class UserDiscord : JsonModel, IUserStatistics
{
    [JsonPropertyName("discord")]
    public Discord Discord { get; set; }

    public string GetMethodName()
    {
        return UserMethods.discord.ToString();
    }
}