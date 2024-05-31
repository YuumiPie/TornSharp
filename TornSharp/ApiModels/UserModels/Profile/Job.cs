using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Profile;

public class Job : JsonModel
{
    [JsonPropertyName("job")]
    public string JobName { get; set; }

    [JsonPropertyName("company_type")]
    public int CompanyType { get; set; }

    [JsonPropertyName("position")]
    public string Position { get; set; }

    [JsonPropertyName("company_id")]
    public int CompanyId { get; set; }

    [JsonPropertyName("company_name")]
    public string CompanyName { get; set; }
}