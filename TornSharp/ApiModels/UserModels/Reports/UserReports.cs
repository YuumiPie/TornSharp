using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Reports;

public class UserReports : JsonModel, IUserStatistics
{
    [JsonPropertyName("reports")]
    public List<Report> Reports { get; set; }

    public string GetMethodName()
    {
        return UserMethods.reports.ToString();
    }
}