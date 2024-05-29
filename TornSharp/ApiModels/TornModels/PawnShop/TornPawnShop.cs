using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.PawnShop;

public class TornPawnShop : JsonModel, ITornStats
{
    [JsonPropertyName("pawnshop")]
    public PawnShop PawnShop { get; set; }

    public string GetMethodName()
    {
        return TornMethods.pawnshop.ToString();
    }
}