using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Money;

public class UserMoney : JsonModel, IUserStatistics
{
    [JsonPropertyName("cayman_bank")]
    public long CaymanBank { get; set; }

    [JsonPropertyName("city_bank")]
    public CityBank CityBank { get; set; }

    [JsonPropertyName("company_funds")]
    public int CompanyFunds { get; set; }

    [JsonPropertyName("daily_networth")]
    public long Networth { get; set; }

    [JsonPropertyName("money_onhand")]
    public int MoneyOnHand { get; set; }

    [JsonPropertyName("points")]
    public int Points { get; set; }

    [JsonPropertyName("vault_amount")]
    public int VaultAmount { get; set; }

    public string GetMethodName()
    {
        return UserMethods.money.ToString();
    }
}