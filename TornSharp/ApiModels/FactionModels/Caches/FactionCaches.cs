using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Caches;

public class FactionCaches : JsonModel, IFactionStats
{
    [JsonPropertyName("caches")]
    public List<ArmoryItem> Caches { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.caches.ToString();
    }
}