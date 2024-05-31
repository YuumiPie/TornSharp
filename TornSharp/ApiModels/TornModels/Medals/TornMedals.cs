using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Medals;

public class TornMedals : JsonModel, ITornStats
{
    [JsonPropertyName("medals")]
    public Dictionary<int, Medal> Medals { get; set; }

    public string GetMethodName()
    {
        return TornMethods.medals.ToString();
    }
}