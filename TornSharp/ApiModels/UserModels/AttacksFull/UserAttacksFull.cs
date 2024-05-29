using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.AttacksFull;

public class UserAttacksFull : JsonModel, IUserStatistics
{
    [JsonPropertyName("attacksfull")]
    Dictionary<string, AttackFull> AttacksFull { get; set; }

    public string GetMethodName()
    {
        return UserMethods.attacksfull.ToString();
    }
}