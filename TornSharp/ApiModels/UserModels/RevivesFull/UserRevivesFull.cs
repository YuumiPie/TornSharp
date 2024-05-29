using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.RevivesFull;

public class UserRevivesFull : JsonModel, IUserStatistics
{
    [JsonPropertyName("revives")]
    public Dictionary<string, RevivesFull> RevivesFull { get; set; }

    public string GetMethodName()
    {
        return UserMethods.revivesfull.ToString();
    }
}