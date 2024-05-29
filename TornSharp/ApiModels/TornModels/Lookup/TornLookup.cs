using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Lookup;

public class TornLookup : JsonModel, ITornStats
{
    [JsonPropertyName("selections")]
    public List<string> Selections { get; set; }

    public string GetMethodName()
    {
        return TornMethods.lookup.ToString();
    }
}