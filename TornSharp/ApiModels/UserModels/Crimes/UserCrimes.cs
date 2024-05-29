﻿using System.Text.Json.Serialization;

namespace TornSharp.ApiModels.UserModels.Crimes;

public class UserCrimes : JsonModel, IUserStatistics
{
    [JsonPropertyName("criminalrecord")]
    public CriminalRecord CriminalRecord { get; set; }

    public string GetMethodName()
    {
        return UserMethods.crimes.ToString();
    }
}