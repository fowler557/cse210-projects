using System;

public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(DateTime date, int lengthInMinutes, int numberOfLaps) : base(date, lengthInMinutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000.0; // the laps are 50 meters
    }
}
  