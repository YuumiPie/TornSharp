using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Education;

public class TornEducation : JsonModel, ITornStats
{
    [JsonPropertyName("education")]
    public Dictionary<string, Education> Education { get; set; }

    public string GetMethodName()
    {
        return TornMethods.education.ToString();
    }
}