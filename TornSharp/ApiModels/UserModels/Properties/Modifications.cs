using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Properties;

public class Modifications : JsonModel
{
    [JsonPropertyName("airstrip")]
    public int Airstrip { get; set; }

    [JsonPropertyName("hot_tub")]
    public int HotTub { get; set; }

    [JsonPropertyName("interior")]
    public int Interior { get; set; }

    [JsonPropertyName("medical_facility")]
    public int MedicalFacility { get; set; }

    [JsonPropertyName("open_bar")]
    public int OpenBar { get; set; }

    [JsonPropertyName("pool")]
    public int Pool { get; set; }

    [JsonPropertyName("sauna")]
    public int Sauna { get; set; }

    [JsonPropertyName("shooting_range")]
    public int ShootingRange { get; set; }

    [JsonPropertyName("vault")]
    public int Vault { get; set; }

    [JsonPropertyName("yacht")]
    public int Yacht { get; set; }
}