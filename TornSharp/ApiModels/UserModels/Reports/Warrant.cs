using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Reports;

public class Warrant : JsonModel
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("user_id")]
    public int UserId { get; set; }

    [JsonPropertyName("warrant")]
    public int WarrantAmount { get; set; }
}