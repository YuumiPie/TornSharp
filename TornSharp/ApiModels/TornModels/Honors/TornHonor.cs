using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.Honors;

public class TornHonor : JsonModel, ITornStats
{
    [JsonPropertyName("honors")]
    public Dictionary<string, Honor> Honors { get; set; }

    public string GetMethodName()
    {
        return TornMethods.honors.ToString();
    }
}