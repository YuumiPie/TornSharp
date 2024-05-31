using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Hof;

public class UserHof : JsonModel, IUserStats
{
    [JsonPropertyName("halloffame")]
    public HallOfFame hof { get; set; }

    public string GetMethodName()
    {
        return UserMethods.hof.ToString();
    }
}