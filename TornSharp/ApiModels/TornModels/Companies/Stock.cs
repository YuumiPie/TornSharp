using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Companies;

public class Stock : JsonModel
{
    [JsonPropertyName("cost")]
    public int Cost { get; set; }

    [JsonPropertyName("rrp")]
    public int Rrp { get; set; }
}