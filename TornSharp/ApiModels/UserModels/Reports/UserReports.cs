using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Reports;

public class UserReports : JsonModel, IUserStats
{
    [JsonPropertyName("reports")]
    public List<Report> Reports { get; set; }

    public string GetMethodName()
    {
        return UserMethods.reports.ToString();
    }
}