using System.Reflection;
using TornSharp.ApiModels;

namespace TornSharp.Utils;

public class JsonDataLogger
{
    public void LogMissingFields<T>(T model, string name = "")
    {
        if (model is null)
        {
            return;
        }
        switch (model)
        {
            case JsonModel { ExtensionData.Count: > 0 } jsonModel when jsonModel.GetType() != typeof(JsonModel):
            {
                Console.WriteLine($"(Please report to the devs!) Found {jsonModel.ExtensionData.Count} extra fields for model {model.GetType().Name} - {name}:\n{jsonModel.ExtensionData}");
                foreach (PropertyInfo property in model.GetType().GetProperties())
                {
                    object? value = property.GetValue(model);
                    if (property.GetValue(model) is JsonModel { ExtensionData.Count: > 0 } && jsonModel.GetType() != typeof(JsonModel))
                    {
                        LogMissingFields(value, property.Name);
                    }
                }
                break;
            }
            case IEnumerable<JsonModel> jsonModels:
            {
                foreach (JsonModel jsnMdl in jsonModels)
                {
                    LogMissingFields(jsnMdl);
                }

                break;
            }
            default:
            {
                PropertyInfo[] properties = model.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
                foreach (PropertyInfo property in properties.Where(x => x.PropertyType.IsAssignableTo(typeof(JsonModel)) || x.PropertyType.IsAssignableTo(typeof(IEnumerable<JsonModel>))))
                {
                    object? propertyValue = property.GetValue(model);
                    if (propertyValue is not null)
                    {
                        LogMissingFields(propertyValue);
                    }
                }
                break;
            }
        }
    }
}