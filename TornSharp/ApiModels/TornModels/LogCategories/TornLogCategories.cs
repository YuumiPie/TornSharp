using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.LogCategories;

public class TornLogCategories : JsonModel, ITornStats
{
    [JsonPropertyName("logcategories")]
    public Dictionary<int, string> LogCategories { get; set; }

    public string GetMethodName()
    {
        return TornMethods.logcategories.ToString();
    }
}