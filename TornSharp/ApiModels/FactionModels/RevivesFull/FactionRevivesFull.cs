using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.RevivesFull;

public class FactionRevivesFull : JsonModel, IFactionStatistics
{
    [JsonPropertyName("revives")]
    public Dictionary<string, RevivesFull> RevivesFull { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.revivesfull.ToString();
    }
}