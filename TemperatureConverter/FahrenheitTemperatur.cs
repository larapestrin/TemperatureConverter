class FahrenheitTemperature
{
    public static readonly TemperatureValidator Range = new(-459.67, 2.556e32, "Fahrenheit");
    
    public static Temperature ToKelvin(double tempToConvert)
    {
        return new Temperature((tempToConvert + 459.67)/(9/5), TemperatureUnit.Kelvin);
    } 
    public static Temperature ToCelsius(double tempToConvert)
    {
        return new Temperature((tempToConvert - 32)/(9/5), TemperatureUnit.Celsius);
    } 
}