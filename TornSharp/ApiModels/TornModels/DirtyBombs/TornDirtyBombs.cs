using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.TornModels.DirtyBombs;

public class TornDirtyBombs : JsonModel, ITornStats
{
    [JsonPropertyName("dirtybombs")]
    public List<DirtyBomb> DirtyBombs { get; set; }

    public string GetMethodName()
    {
        return TornMethods.dirtybombs.ToString();
    }
}