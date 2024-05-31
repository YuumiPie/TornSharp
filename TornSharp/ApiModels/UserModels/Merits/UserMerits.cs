using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Merits;

public class UserMerits : JsonModel, IUserStats
{
    [JsonPropertyName("merits")]
    public Merits merits { get; set; }

    public string GetMethodName()
    {
        return UserMethods.merits.ToString();
    }
}