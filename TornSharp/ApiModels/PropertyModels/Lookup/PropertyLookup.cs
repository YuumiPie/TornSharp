using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.PropertyModels.Lookup;

public class PropertyLookup : JsonModel, IPropertyStatistics
{
    [JsonPropertyName("selections")]
    public List<string> Selections { get; set; }

    public string GetMethodName()
    {
        return PropertyMethods.lookup.ToString();
    }
}