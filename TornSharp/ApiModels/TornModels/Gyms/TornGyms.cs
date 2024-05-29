using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Gyms;

public class TornGyms : JsonModel, ITornStats
{
    [JsonPropertyName("gyms")]
    public Dictionary<string, Gym> Gyms { get; set; }

    public string GetMethodName()
    {
        return TornMethods.gyms.ToString();
    }
}