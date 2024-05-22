class CelsiusTemperature
{
    public static readonly TemperatureValidator Range = new(-273.15, 1.42e32, "Celsius");

    public static Temperature ToFahrenheit(double tempToConvert)
    {
        return new Temperature(tempToConvert * 1.8 + 32, TemperatureUnit.Fahrenheit);
    } 
    public static Temperature ToKelvin(double tempToConvert)
    {
        return new Temperature(tempToConvert + 273.15, TemperatureUnit.Kelvin);
    } 
}

