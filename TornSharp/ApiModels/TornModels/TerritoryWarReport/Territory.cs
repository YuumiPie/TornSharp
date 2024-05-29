using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.TerritoryWarReport;

public class Territory : JsonModel
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
}