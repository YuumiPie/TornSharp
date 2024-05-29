using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.CompanyModels.Detailed;

public class Upgrades : JsonModel
{
    [JsonPropertyName("company_size")]
    public int CompanySize { get; set; }

    [JsonPropertyName("staffroom_size")]
    public string StaffroomSize { get; set; }

    [JsonPropertyName("storage_size")]
    public string StorageSize { get; set; }

    [JsonPropertyName("storage_space")]
    public int StorageSpace { get; set; }
}