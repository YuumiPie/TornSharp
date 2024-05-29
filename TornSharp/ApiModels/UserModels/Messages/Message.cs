using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Messages;

public class Message : JsonModel
{
    [JsonPropertyName("Id")]
    public int MessageId { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("read")]
    public bool Read { get; set; }

    [JsonPropertyName("seen")]
    public bool Seen { get; set; }

    [JsonPropertyName("timestamp")]
    public int Timestamp { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("type")]
    public MessageType Type { get; set; }
}