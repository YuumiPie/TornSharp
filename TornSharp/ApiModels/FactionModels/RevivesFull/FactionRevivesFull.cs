using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.RevivesFull;

public class FactionRevivesFull : JsonModel, IFactionStats
{
    [JsonPropertyName("revives")]
    public Dictionary<int, RevivesFull> RevivesFull { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.revivesfull.ToString();
    }
}