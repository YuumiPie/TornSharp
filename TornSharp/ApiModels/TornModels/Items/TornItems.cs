using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Items;

public class TornItems : JsonModel, ITornStats
{
    [JsonPropertyName("items")]
    public Dictionary<int, Item> Items { get; set; }

    public string GetMethodName()
    {
        return TornMethods.items.ToString();
    }
}