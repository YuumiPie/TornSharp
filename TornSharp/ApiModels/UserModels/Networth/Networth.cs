using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Networth;

public class Networth : JsonModel
{
    [JsonPropertyName("auctionhouse")]
    public int Auctionhouse { get; set; }

    [JsonPropertyName("bank")]
    public long Bank { get; set; }

    [JsonPropertyName("bazaar")]
    public int Bazaar { get; set; }

    [JsonPropertyName("bookie")]
    public long Bookie { get; set; }

    [JsonPropertyName("cayman")]
    public long Cayman { get; set; }

    [JsonPropertyName("company")]
    public long Company { get; set; }

    [JsonPropertyName("displaycase")]
    public int Displaycase { get; set; }

    [JsonPropertyName("enlistedcars")]
    public int ElistedCars { get; set; }

    [JsonPropertyName("itemmarket")]
    public int ItemMarket { get; set; }

    [JsonPropertyName("items")]
    public int Items { get; set; }

    [JsonPropertyName("loan")]
    public int Loan { get; set; }

    [JsonPropertyName("parsetime")]
    public double Parsetime { get; set; }

    [JsonPropertyName("pending")]
    public long Pending { get; set; }

    [JsonPropertyName("piggybank")]
    public long PiggyBank { get; set; }

    [JsonPropertyName("points")]
    public int Points { get; set; }

    [JsonPropertyName("properties")]
    public int Properties { get; set; }

    [JsonPropertyName("stockmarket")]
    public long Stockmarket { get; set; }

    [JsonPropertyName("total")]
    public long Total { get; set; }

    [JsonPropertyName("trade")]
    public int Trade { get; set; }

    [JsonPropertyName("unpaidfees")]
    public int Unpaidfees { get; set; }

    [JsonPropertyName("vault")]
    public int Vault { get; set; }

    [JsonPropertyName("wallet")]
    public long Wallet { get; set; }
}