class Temperature
{
    public double Value;
    public TemperatureUnit Unit;

    public Temperature(double value, TemperatureUnit unit)
    {
        Value = value;
        Unit = unit;
    }

    public override string ToString()
    {
        return $"{Math.Round(Value, 2)}{Unit.SiUnit()}";
    }
}