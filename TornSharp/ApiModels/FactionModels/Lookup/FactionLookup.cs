using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Lookup;

public class FactionLookup : JsonModel, IFactionStats
{
    [JsonPropertyName("selections")]
    public List<string> Selections { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.lookup.ToString();
    }
}