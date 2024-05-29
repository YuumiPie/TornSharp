using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Bank;

public class TornBank : JsonModel, ITornStats
{
    [JsonPropertyName("bank")]
    public Bank Bank { get; set; }

    public string GetMethodName()
    {
        return TornMethods.bank.ToString();
    }
}