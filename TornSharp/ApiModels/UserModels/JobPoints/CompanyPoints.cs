using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.JobPoints;

public class CompanyPoints : JsonModel
{
    [JsonPropertyName("jobpoints")]
    public int JobPoints { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}