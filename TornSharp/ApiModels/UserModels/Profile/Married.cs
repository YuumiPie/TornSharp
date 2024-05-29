using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Profile;

public class Married : JsonModel
{
    [JsonPropertyName("duration")]
    public int Duration { get; set; }

    [JsonPropertyName("spouse_id")]
    public int SpouseId { get; set; }

    [JsonPropertyName("spouse_name")]
    public string SpouseName { get; set; }
}