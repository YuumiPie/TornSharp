using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Companies;

public class Company : JsonModel
{
    [JsonPropertyName("cost")]
    public int Cost { get; set; }

    [JsonPropertyName("default_employees")]
    public int DefaultEmployees { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("positions")]
    public Dictionary<string, Position> Positions { get; set; }

    [JsonPropertyName("specials")]
    public Dictionary<string, Special> Specials { get; set; }

    [JsonPropertyName("stock")]
    public Dictionary<string, Stock> Stocks { get; set; }
}