using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.PokerTables;

public class TornPokerTables : JsonModel, ITornStats
{
    [JsonPropertyName("pokertables")]
    public Dictionary<string, PokerTable> PokerTables { get; set; }

    public string GetMethodName()
    {
        return TornMethods.pokertables.ToString();
    }
}