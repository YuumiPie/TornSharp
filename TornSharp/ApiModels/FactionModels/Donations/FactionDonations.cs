using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Donations;

public class FactionDonations : JsonModel, IFactionStats
{
    [JsonPropertyName("donations")]
    public Dictionary<long, Donation> Donations { get; set; }

    public string GetMethodName()
    {
        return FactionMethods.donations.ToString();
    }
}