using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Profile;

public class Job : JsonModel
{
    [JsonPropertyName("position")]
    public string Position { get; set; }

    [JsonPropertyName("company_id")]
    public int CompanyId { get; set; }

    [JsonPropertyName("company_name")]
    public string CompanyName { get; set; }
}