using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Revives;

public class FactionRevives : JsonModel, IFactionStats
{
    [JsonPropertyName("revives")]
    public Dictionary<int, Revive> Revives { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.revives.ToString();
    }
}