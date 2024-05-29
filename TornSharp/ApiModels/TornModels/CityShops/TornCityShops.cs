using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.CityShops;

public class TornCityShops : JsonModel, ITornStats
{
    [JsonPropertyName("cityshops")]
    public Dictionary<string, Shop> CityShops { get; set; }

    public string GetMethodName()
    {
        return TornMethods.cityshops.ToString();
    }
}