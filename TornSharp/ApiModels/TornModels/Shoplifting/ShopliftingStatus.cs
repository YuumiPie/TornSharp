using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.TornModels.Shoplifting;

public class ShopliftingStatus : JsonModel
{
    [JsonPropertyName("disabled")]
    [JsonConverter(typeof(BoolConverter))]
    public bool Disabled { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }
}