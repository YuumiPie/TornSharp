using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.CompanyModels.Applications;

public class Application : JsonModel
{
    [JsonPropertyName("expires")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Expires { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("stats")]
    public Stats? Stats { get; set; }

    [JsonPropertyName("status")]
    public Status Status { get; set; }

    [JsonPropertyName("userID")]
    public int UserId { get; set; }
}