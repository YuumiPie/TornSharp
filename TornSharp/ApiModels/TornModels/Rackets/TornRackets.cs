using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Rackets;

public class TornRackets : JsonModel, ITornStats
{
    [JsonPropertyName("rackets")]
    public Dictionary<string, Racket> Rackets { get; set; }

    public string GetMethodName()
    {
        return TornMethods.rackets.ToString();
    }
}