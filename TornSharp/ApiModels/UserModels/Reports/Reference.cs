using System.Text.Json.Serialization;
using TornSharp.ApiModels;

namespace TornSharp.ApiModels.UserModels.Reports;

public class Reference : JsonModel
{
    [JsonPropertyName("ID")]
    public int Id { get; set; }
    
    [JsonPropertyName("joined")]
    public string Joined { get; set; }
    
    [JsonPropertyName("left")]
    public string Left { get; set; }
    
    [JsonPropertyName("name")]
    public string Name { get; set; }
}