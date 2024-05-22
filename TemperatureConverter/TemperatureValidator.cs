class TemperatureValidator
{
    public readonly double Min;
    public readonly double Max;
    public readonly string Unit;

    public TemperatureValidator(double min, double max, string unit)
    {
        if (min > max)
        {
            throw new InvalidDataException ("Maximum Temperature must be greater than Minimus Temperature.");
        }
        Min = min;
        Max = max;
        Unit = unit;
    }

    public bool IsInRange(double temp)
    {
        return !(temp > Max || temp < Min);
            //throw new ArgumentOutOfRangeException($"The Temperature must be between {Min} and {Max} {Unit}. Outside this range the temperature is physically not possible.");
    }
}

