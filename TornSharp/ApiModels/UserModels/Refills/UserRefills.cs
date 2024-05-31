using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Refills;

public class UserRefills : JsonModel, IUserStats
{
    [JsonPropertyName("refills")]
    public Refills Refills { get; set; }

    public string GetMethodName()
    {
        return UserMethods.refills.ToString();
    }
}