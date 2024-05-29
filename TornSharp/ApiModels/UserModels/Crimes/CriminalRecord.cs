using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Crimes;

public class CriminalRecord : JsonModel
{
    [JsonPropertyName("auto_theft")]
    public int? AutoTheft { get; set; }

    [JsonPropertyName("computer_crimes")]
    public int? ComputerCrimes { get; set; }

    [JsonPropertyName("counterfeiting")]
    public int? Counterfeiting { get; set; }

    [JsonPropertyName("cybercrime")]
    public int? Cybercrime { get; set; }

    [JsonPropertyName("drug_deals")]
    public int? DrugDeals { get; set; }

    [JsonPropertyName("extortion")]
    public int? Extortion { get; set; }

    [JsonPropertyName("fraud")]
    public int? Fraud { get; set; }

    [JsonPropertyName("fraud_crimes")]
    public int? FraudCrimes { get; set; }

    [JsonPropertyName("illegalproduction")]
    public int? IllegalProduction { get; set; }

    [JsonPropertyName("illicitservices")]
    public int? IllicitServices { get; set; }

    [JsonPropertyName("murder")]
    public int? Murder { get; set; }

    [JsonPropertyName("other")]
    public int? Other { get; set; }

    [JsonPropertyName("selling_illegal_products")]
    public int? SellingIllegalProducts { get; set; }

    [JsonPropertyName("theft")]
    public int Theft { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }

    [JsonPropertyName("vandalism")]
    public int? Vandalism { get; set; }
}