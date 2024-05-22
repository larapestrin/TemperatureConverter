class KelvinTemperature
{
    public static readonly TemperatureValidator Range = new(0, 1.417e32, "Kelvin");
   
    public static Temperature ToFahrenheit(double tempToConvert)
    {
        return new Temperature(tempToConvert * 1.8 - 459.67, TemperatureUnit.Fahrenheit);
    } 
    public static Temperature ToCelsius(double tempToConvert)
    {
        return new Temperature(tempToConvert - 273.15, TemperatureUnit.Celsius);
    } 
}