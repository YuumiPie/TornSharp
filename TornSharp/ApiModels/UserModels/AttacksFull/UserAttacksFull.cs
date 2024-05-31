using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.AttacksFull;

public class UserAttacksFull : JsonModel, IUserStats
{
    [JsonPropertyName("attacksfull")]
    Dictionary<int, AttackFull> AttacksFull { get; set; }

    public string GetMethodName()
    {
        return UserMethods.attacksfull.ToString();
    }
}