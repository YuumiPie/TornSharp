using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Medals;

public class UserMedals : JsonModel, IUserStatistics
{
    [JsonPropertyName("medals_awarded")]
    public List<int> MedalsAwarded { get; set; }

    [JsonPropertyName("medals_time")]
    public List<int> MedalsTime { get; set; }

    public string GetMethodName()
    {
        return UserMethods.medals.ToString();
    }
}