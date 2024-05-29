using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Merits;

public class UserMerits : JsonModel, IUserStatistics
{
    [JsonPropertyName("merits")]
    public Merits merits { get; set; }

    public string GetMethodName()
    {
        return UserMethods.merits.ToString();
    }
}