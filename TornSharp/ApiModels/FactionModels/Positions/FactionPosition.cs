using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Positions;

public class FactionPosition : JsonModel, IFactionStatistics
{
    [JsonPropertyName("positions")]
    public Dictionary<string, Position> Positions { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.positions.ToString();
    }
}