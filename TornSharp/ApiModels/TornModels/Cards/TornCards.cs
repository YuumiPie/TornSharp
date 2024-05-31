using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Cards;

public class TornCards : JsonModel, ITornStats
{
    [JsonPropertyName("cards")]
    public Dictionary<int, Card> Cards { get; set; }

    public string GetMethodName()
    {
        return TornMethods.cards.ToString();
    }
}