using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Education;

public class UserEducation : JsonModel, IUserStatistics
{
    [JsonPropertyName("education_completed")]
    public List<int> EducationCompleted { get; set; }

    [JsonPropertyName("education_current")]
    public int EducationCurrent { get; set; }

    [JsonPropertyName("education_timeleft")]
    public int EducationTimeLeft { get; set; }

    public string GetMethodName()
    {
        return UserMethods.education.ToString();
    }
}