using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Positions;

public class FactionPosition : JsonModel, IFactionStats
{
    [JsonPropertyName("positions")]
    public Dictionary<int, Position> Positions { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.positions.ToString();
    }
}