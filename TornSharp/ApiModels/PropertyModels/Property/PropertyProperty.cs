using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.PropertyModels.Property;

public class PropertyProperty : JsonModel, IPropertyStats
{
    [JsonPropertyName("property")]
    public Property Property { get; set; }

    public string GetMethodName()
    {
        return PropertyMethods.property.ToString();
    }
}