using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Shoplifting;

public class TornShoplifting : JsonModel, ITornStats
{
    [JsonPropertyName("shoplifting")]
    public Dictionary<string, List<ShopliftingStatus>> Shoplifting { get; set; }

    public string GetMethodName()
    {
        return TornMethods.shoplifting.ToString();
    }
}