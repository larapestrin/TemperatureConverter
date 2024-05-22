Console.WriteLine("Welcome to the Temperature Converter.");
TemperatureUnit unitInput = CliRunner.GetUnitValue();
double temperatureInput = CliRunner.GetTemperatureValue(unitInput);

switch (unitInput)
{
    case TemperatureUnit.Celsius:
        Printer.PrintTemperature(
            new Temperature(temperatureInput, TemperatureUnit.Celsius),
            CelsiusTemperature.ToFahrenheit(temperatureInput),
            CelsiusTemperature.ToKelvin(temperatureInput)
        );
        break;
    case TemperatureUnit.Fahrenheit:
        Printer.PrintTemperature(
            new Temperature(temperatureInput, TemperatureUnit.Fahrenheit),
            FahrenheitTemperature.ToCelsius(temperatureInput),
            FahrenheitTemperature.ToKelvin(temperatureInput)
        );
        break;
    case TemperatureUnit.Kelvin:
        Printer.PrintTemperature(
            new Temperature(temperatureInput, TemperatureUnit.Kelvin),
            KelvinTemperature.ToCelsius(temperatureInput),
            KelvinTemperature.ToFahrenheit(temperatureInput)
        );
        break;
}