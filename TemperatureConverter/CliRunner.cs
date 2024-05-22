class CliRunner
{
    public static TemperatureUnit GetUnitValue()
    {
        while (true)
        {
            Console.WriteLine("Enter to be convertered Temperature (e.g K (Kelvin), C (Celsius), F (Fahreinheit): ");
            string temperatureUnitFrom = Console.ReadLine().ToUpper();
            string[] validInput = ["C", "K", "F"];
            if (validInput.Contains(temperatureUnitFrom))
            {
                return temperatureUnitFrom.ToTemperatureUnit();
            }
            Console.WriteLine("You entered not a valid unit.");
        }
    }

    public static double GetTemperatureValue(TemperatureUnit temperatureUnitFrom)
    {
        while (true)
        {
            Console.WriteLine("Enter number: ");
            if (!double.TryParse(Console.ReadLine(), out double temperatureToConvert))
            {
                Console.WriteLine("You entered a text and not a number!");
                continue;
            }

            bool isCorrectRange = temperatureUnitFrom switch
            {
                TemperatureUnit.Celsius => CelsiusTemperature.Range.IsInRange(temperatureToConvert),
                TemperatureUnit.Fahrenheit => FahrenheitTemperature.Range.IsInRange(temperatureToConvert),
                TemperatureUnit.Kelvin => KelvinTemperature.Range.IsInRange(temperatureToConvert),
                _ => throw new Exception("Not possible")
            };

            if (isCorrectRange)
            {
                return temperatureToConvert;
            }
            Console.WriteLine("Your temperature is not physically possible. Please enter again.");
        }
    }
}