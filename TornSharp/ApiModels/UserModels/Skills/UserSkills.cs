using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Skills;

public class UserSkills : JsonModel, IUserStats
{
    [JsonPropertyName("bootlegging")]
    public string? Bootlegging { get; set; }

    [JsonPropertyName("burglary")]
    public string? Burglary { get; set; }

    [JsonPropertyName("card_skimming")]
    public string? CardSkimming { get; set; }

    [JsonPropertyName("cracking")]
    public string? Cracking { get; set; }

    [JsonPropertyName("disposal")]
    public string? Disposal { get; set; }

    [JsonPropertyName("forgery")]
    public string? Forgery { get; set; }

    [JsonPropertyName("graffiti")]
    public string? Graffiti { get; set; }

    [JsonPropertyName("hunting")]
    public string Hunting { get; set; }

    [JsonPropertyName("hustling")]
    public string? Hustling { get; set; }

    [JsonPropertyName("pickpocketing")]
    public string? Pickpcoketing { get; set; }

    [JsonPropertyName("player_id")]
    public int PlayerId { get; set; }

    [JsonPropertyName("racing")]
    public string Racing { get; set; }

    [JsonPropertyName("reviving")]
    public string Reviving { get; set; }

    [JsonPropertyName("search_for_cash")]
    public string? SearchForCash { get; set; }

    [JsonPropertyName("shoplifting")]
    public string? Shoplifing { get; set; }

    public string GetMethodName()
    {
        return UserMethods.skills.ToString();
    }
}