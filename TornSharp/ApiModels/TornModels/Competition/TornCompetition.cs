using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Competition;

public class TornCompetition : JsonModel, ITornStats
{
    [JsonPropertyName("competition")]
    public Competition? Competition { get; set; }

    public string GetMethodName()
    {
        return TornMethods.competition.ToString();
    }
}