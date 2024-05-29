using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.OrganizedCrimes;

public class TornOrganizedCrimes : JsonModel, ITornStats
{
    [JsonPropertyName("organisedcrimes")]
    public Dictionary<string, OrganizedCrime> OrganizedCrimes { get; set; }

    public string GetMethodName()
    {
        return TornMethods.organisedcrimes.ToString();
    }
}