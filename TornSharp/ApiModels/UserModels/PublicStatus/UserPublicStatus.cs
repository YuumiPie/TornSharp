using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.PublicStatus;

public class UserPublicStatus : JsonModel, IUserStats
{
    [JsonPropertyName("baned")]
    public bool Banned { get; set; }

    [JsonPropertyName("playername")]
    public string PlayerName { get; set; }

    [JsonPropertyName("status")]
    public Role Status { get; set; }

    [JsonPropertyName("userID")]
    public int UserId { get; set; }

    public string GetMethodName()
    {
        return UserMethods.publicstatus.ToString();
    }
}