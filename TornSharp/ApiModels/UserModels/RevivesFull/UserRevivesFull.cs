using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.RevivesFull;

public class UserRevivesFull : JsonModel, IUserStats
{
    [JsonPropertyName("revives")]
    public Dictionary<int, RevivesFull> RevivesFull { get; set; }

    public string GetMethodName()
    {
        return UserMethods.revivesfull.ToString();
    }
}