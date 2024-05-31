using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.JobPoints;

public class JobPoints : JsonModel
{
    [JsonPropertyName("companies")]
    public Dictionary<int, CompanyPoints> Companies { get; set; }

    [JsonPropertyName("jobs")]
    public Jobs Jobs { get; set; }
}