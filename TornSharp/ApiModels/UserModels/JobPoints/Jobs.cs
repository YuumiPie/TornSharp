using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.JobPoints;

public class Jobs : JsonModel
{
    [JsonPropertyName("army")]
    public int? Army { get; set; }

    [JsonPropertyName("casino")]
    public int? Casino { get; set; }

    [JsonPropertyName("education")]
    public int? Education { get; set; }

    [JsonPropertyName("grocer")]
    public int? Grocer { get; set; }

    [JsonPropertyName("law")]
    public int? Law { get; set; }

    [JsonPropertyName("medical")]
    public int? Medical { get; set; }
}