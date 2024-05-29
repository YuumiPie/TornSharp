using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.CompanyModels.Stock;

public class CompanyStock : JsonModel
{
    [JsonPropertyName("company_stock")]
    public Dictionary<int, StockItem> Stock { get; set; }

    public string GetMethodName()
    {
        return CompanyMethods.stock.ToString();
    }
}