﻿using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Display;

public class UserDisplay : JsonModel, IUserStats
{
    [JsonPropertyName("display")]
    public List<Display> Display { get; set; }

    public string GetMethodName()
    {
        return UserMethods.display.ToString();
    }
}