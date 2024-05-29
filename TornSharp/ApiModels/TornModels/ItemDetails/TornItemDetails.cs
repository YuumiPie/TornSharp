using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.ItemDetails;

public class TornItemDetails : JsonModel, ITornStats
{
    [JsonPropertyName("itemdetails")]
    public ItemDetail ItemDetails { get; set; }

    public string GetMethodName()
    {
        return TornMethods.itemdetails.ToString();
    }
}