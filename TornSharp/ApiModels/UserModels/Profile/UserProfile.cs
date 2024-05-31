using System.Text.Json.Serialization;
using TornSharp.CustomJsonConverter;

namespace TornSharp.ApiModels.UserModels.Profile;

public class UserProfile : JsonModel, IUserStats
{
    [JsonPropertyName("age")]
    public int Age { get; set; }

    [JsonPropertyName("awards")]
    public int Awards { get; set; }

    //icon{int} format for some reason
    [JsonPropertyName("basicicons")]
    public Dictionary<string, string> Icons { get; set; }

    [JsonPropertyName("competition")]
    public Competition? Competition { get; set; }

    [JsonPropertyName("donator")]
    [JsonConverter(typeof(BoolConverter))]
    public bool Donator { get; set; }

    [JsonPropertyName("enemies")]
    public int Enemies { get; set; }

    [JsonPropertyName("faction")]
    public Faction Faction { get; set; }

    [JsonPropertyName("forum_posts")]
    public int ForumPosts { get; set; }

    [JsonPropertyName("friends")]
    public int Friends { get; set; }

    [JsonPropertyName("gender")]
    public Gender Gender { get; set; }

    [JsonPropertyName("honor")]
    public int Honor { get; set; }

    [JsonPropertyName("job")]
    public Job Job { get; set; }

    [JsonPropertyName("karma")]
    public int Karma { get; set; }

    [JsonPropertyName("last_action")]
    public LastAction LastAction { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("life")]
    public Bar Life { get; set; }

    [JsonPropertyName("married")]
    public Married Married { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("player_id")]
    public int PlayerId { get; set; }

    [JsonPropertyName("profile_image")]
    public string? ProfileImage { get; set; }

    [JsonPropertyName("property")]
    public string Property { get; set; }

    [JsonPropertyName("property_id")]
    public int PropertyId { get; set; }

    [JsonPropertyName("rank")]
    public string Rank { get; set; }

    [JsonPropertyName("revivable")]
    [JsonConverter(typeof(BoolConverter))]
    public bool Revivable { get; set; }

    [JsonPropertyName("role")]
    public string Role { get; set; }
    
    [JsonPropertyName("signup")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime Signup { get; set; }

    [JsonPropertyName("states")]
    public States States { get; set; }

    [JsonPropertyName("status")]
    public Status Status { get; set; }

    public string GetMethodName()
    {
        return UserMethods.profile.ToString();
    }
}