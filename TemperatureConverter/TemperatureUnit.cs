public enum TemperatureUnit
{
    Celsius,
    Fahrenheit,
    Kelvin
}
public static class Extensions
{
    public static string SiUnit(this TemperatureUnit unit)
    {
        return unit switch
        {
            TemperatureUnit.Celsius => "°C",
            TemperatureUnit.Fahrenheit => "°F",
            TemperatureUnit.Kelvin => "K",
            _ => "",
        };
    }

    public static TemperatureUnit ToTemperatureUnit(this string s)
    {
        return s switch
       {
         "C" => TemperatureUnit.Celsius,
         "F" => TemperatureUnit.Fahrenheit,
         "K" => TemperatureUnit.Kelvin,
         _ => throw new Exception("Not a valid input.")
       }; 

    }
}