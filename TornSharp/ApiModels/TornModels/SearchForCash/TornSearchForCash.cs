using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.SearchForCash;

public class TornSearchForCash : JsonModel, ITornStats
{
    [JsonPropertyName("searchforcash")]
    public Dictionary<string, SearchForCashSubcrime> SearchForCash { get; set; }

    public string GetMethodName()
    {
        return TornMethods.searchforcash.ToString();
    }
}