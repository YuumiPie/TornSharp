using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Reports;

public class FactionReports : JsonModel, IFactionStatistics
{
    [JsonPropertyName("reports")]
    public List<Report> Reports { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.reports.ToString();
    }
}