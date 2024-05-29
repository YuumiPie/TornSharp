using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Raids;

public class TornRaid : JsonModel, ITornStats
{
    [JsonPropertyName("raids")]
    public Dictionary<string, Raid> Raids { get; set; }

    public string GetMethodName()
    {
        return TornMethods.raids.ToString();
    }
}