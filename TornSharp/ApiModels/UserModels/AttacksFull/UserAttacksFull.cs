using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.AttacksFull;

public class UserAttacksFull : JsonModel, IUserStats
{
    [JsonPropertyName("attacks")]
    public Dictionary<int, AttackFull> AttacksFull { get; set; }

    public string GetMethodName()
    {
        return UserMethods.attacksfull.ToString();
    }
}