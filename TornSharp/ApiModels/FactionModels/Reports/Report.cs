using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Reports;

public class Report : JsonModel
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("report")]
    public ReportData ReportData { get; set; }

    [JsonPropertyName("target")]
    public int Target { get; set; }

    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; set; }

    [JsonPropertyName("type")]
    public ReportType Type { get; set; }

    [JsonPropertyName("user_id")]
    public int UserId { get; set; }
}