using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Revives;

public class FactionRevives : JsonModel, IFactionStatistics
{
    [JsonPropertyName("revives")]
    public Dictionary<string, Revive> Revives { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.revives.ToString();
    }
}