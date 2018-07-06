using System;

public struct Clock
{
    private const int MinutesPerHour = 60;
    private const int MinutesPerDay = 60 * 24;
    private readonly int timeOfDayInMinutes;

    public readonly int Hours;
    public readonly int Minutes;

    public Clock(int hours, int minutes)
    {
        this.timeOfDayInMinutes = (MinutesPerDay + ((hours * MinutesPerHour + minutes) % (MinutesPerDay))) % (MinutesPerDay);
        this.Hours = this.timeOfDayInMinutes / MinutesPerHour;
        this.Minutes = this.timeOfDayInMinutes % MinutesPerHour;
    }


    public Clock Add(int minutesToAdd) => new Clock(0, this.timeOfDayInMinutes + minutesToAdd);

    public Clock Subtract(int minutesToSubtract) => new Clock(0, this.timeOfDayInMinutes - minutesToSubtract);

    public override string ToString() => $"{Hours:D2}:{Minutes:D2}";
}