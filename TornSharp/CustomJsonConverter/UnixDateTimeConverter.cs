using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace TornSharp.CustomJsonConverter;

public class UnixDateTimeConverter : JsonConverter<DateTime>
{
    static readonly DateTime s_epoch = new(1970, 1, 1, 0, 0, 0);
    static readonly Regex s_regex = new(@"^/Date\(([+-]*\d+)\)/$", RegexOptions.CultureInvariant);

    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string formatted = reader.GetString()!;
        Match match = s_regex.Match(formatted);

        if (
            !match.Success
            || !long.TryParse(match.Groups[1].Value, System.Globalization.NumberStyles.Integer, CultureInfo.InvariantCulture, out long unixTime))
        {
            throw new JsonException();
        }

        return s_epoch.AddMilliseconds(unixTime);
    }

    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        long unixTime = Convert.ToInt64((value - s_epoch).TotalMilliseconds);

        string formatted = string.Create(CultureInfo.InvariantCulture, $"/Date({unixTime})/");
        writer.WriteStringValue(formatted);
    }
}