using System;

public struct Clock
{
    const int MinutesPerHour = 60;
    const int MinutesPerDay = 60 * 24;

    private int minutes;
    public Clock(int hours, int minutes)
    {
        this.minutes = (MinutesPerDay + ((hours * MinutesPerHour + minutes) % (MinutesPerDay))) % (MinutesPerDay);
    }

    public int Hours
    {
        get
        {
            return this.minutes / MinutesPerHour;
        }
    }

    public int Minutes
    {
        get
        {
            return this.minutes % MinutesPerHour;
        }
    }

    public Clock Add(int minutesToAdd)
    {
        return new Clock(0, this.minutes + minutesToAdd);
    }

    public Clock Subtract(int minutesToSubtract)
    {
        return new Clock(0, this.minutes - minutesToSubtract);
    }

    public override string ToString()
    {
        return $"{Hours,0:D2}:{Minutes,0:D2}";
    }
}