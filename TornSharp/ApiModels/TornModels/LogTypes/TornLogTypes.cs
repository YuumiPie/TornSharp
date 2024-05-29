using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.LogTypes;

public class TornLogTypes : JsonModel, ITornStats
{
    [JsonPropertyName("logtypes")]
    public Dictionary<string, string> LogTypes { get; set; }

    public string GetMethodName()
    {
        return TornMethods.logtypes.ToString();
    }
}