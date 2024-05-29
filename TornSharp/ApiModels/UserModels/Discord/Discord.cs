using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Discord;

public class Discord : JsonModel
{
    [JsonPropertyName("discordID")]
    public string DiscordId { get; set; }

    [JsonPropertyName("userID")]
    public int UserId { get; set; }
}