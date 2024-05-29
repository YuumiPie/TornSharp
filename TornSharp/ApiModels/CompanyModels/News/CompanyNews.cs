using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.CompanyModels.News;

public class CompanyNews : JsonModel
{
    [JsonPropertyName("news")]
    public Dictionary<string, NewsEntry> News { get; set; }

    public string GetMethodName()
    {
        return CompanyMethods.news.ToString();
    }
}