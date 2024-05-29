using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.FactionModels.Territory;

public class Territory : JsonModel
{
    [JsonPropertyName("coordinate_x")]
    public string CoordinateX { get; set; }

    [JsonPropertyName("coordinate_y")]
    public string CoordinateY { get; set; }

    [JsonPropertyName("daily_respect")]
    public int DailyRespect { get; set; }

    [JsonPropertyName("density")]
    public int Density { get; set; }

    [JsonPropertyName("faction")]
    public int Faction { get; set; }

    [JsonPropertyName("racket")]
    public Racket? Racket { get; set; }

    [JsonPropertyName("sector")]
    public int Sector { get; set; }

    [JsonPropertyName("size")]
    public int Size { get; set; }

    [JsonPropertyName("slots")]
    public int Slots { get; set; }
}