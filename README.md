# TornSharp
A C# Wrapper for [Torn City API](https://www.torn.com/api.html) based on the now depreciated wrapper by CarlHalstead.

### Features:
- Asynchronous Calls
- Support for most endpoints
- Logging unknown Json properties

## Usage
You first have to create API key [here](https://www.torn.com/preferences.php#tab=api).

Entry point for the API:
```c#
var api = new TornApiWrapper("YOUR_API_KEY");
```

Specifying rate limit (unspecified defaults to unlimited):
```c#
var api = new TornApiWrapper("YOUR_API_KEY", yourRateLimit);
```

Disabling unknown Json logging:
```c#
var api = new TornApiWrapper("YOUR_API_KEY", yourRateLimit, false);
```

To get basic data of a Torn User:
```c#
try
{
  //example: Chedburn [1]
  var user = api.GetFromUserApi<UserBasic>("1").Result;
  var name = user.Name;
  var level = user.Level;
  var playerId = user.PlayerId;
}
catch (Exception e)
{
  // Handle the exception
}
```
These are the current endpoint category available:
* User
* Property
* Faction
* Company
* Market
* Torn
* Key

All endpoints can be found on the [Unofficial Torn Api](https://tornapi.tornplayground.eu/).

## Notes
- Some endpoints/types are incomplete due to unknown variable types/enum types
- Incorrect data or errors may occur on integer types (int vs long)

These problems are mostly due to incomplete/unknown data from the unofficial documentation.<br />

If any of these problems above occur you can open an issue [here](https://github.com/YuumiPie/TornCitySharp/issues).<br />
(please report unknown/incomplete data to the Unofficial Torn Api as well)!

## Contributing

Contributions can be made by opening a pull request [here](https://github.com/YuumiPie/TornCitySharp/pulls).

## Dependencies
- System.Text.Json
- System.Text.Json.EnumExtensions

## Licence
This wrapper is under the [Apache 2.0 License](LICENSE.md).

## Credits
This is heavily based on [TornCityApiSharp by CarlHalstead](https://github.com/CarlHalstead/TornCityAPISharp).<br />
All the Json models are based on the [Unofficial Torn Api](https://tornapi.tornplayground.eu/).
