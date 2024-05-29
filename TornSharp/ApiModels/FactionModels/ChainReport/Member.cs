using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.ChainReport;

public class Member : JsonModel
{
    [JsonPropertyName("assist")]
    public int Assist { get; set; }

    [JsonPropertyName("attacks")]
    public int Attacks { get; set; }

    [JsonPropertyName("avg")]
    public double Avg { get; set; }

    [JsonPropertyName("best")]
    public double Best { get; set; }

    [JsonPropertyName("bonus")]
    public int Bonus { get; set; }

    [JsonPropertyName("draw")]
    public int Draw { get; set; }

    [JsonPropertyName("escape")]
    public int Escape { get; set; }

    [JsonPropertyName("factionID")]
    public int FactionId { get; set; }

    [JsonPropertyName("hosp")]
    public int Hosp { get; set; }

    [JsonPropertyName("leave")]
    public int Leave { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("loss")]
    public int Loss { get; set; }

    [JsonPropertyName("mug")]
    public int Mug { get; set; }

    [JsonPropertyName("overseas")]
    public int Overseas { get; set; }

    [JsonPropertyName("respect")]
    public double Respect { get; set; }

    [JsonPropertyName("retal")]
    public int Retaliation { get; set; }

    [JsonPropertyName("userID")]
    public int UserId { get; set; }

    [JsonPropertyName("war")]
    public int War { get; set; }
}