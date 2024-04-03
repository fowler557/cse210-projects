using System;

public abstract class Activity
{
    private DateTime _date;
    private int _lengthInMinutes;

    protected Activity(DateTime date, int lengthInMinutes)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetLengthInMinutes()
    {
        return _lengthInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public double GetSpeed()
    {
        return GetDistance() / (_lengthInMinutes / 60.0);
    }

    public double GetPace()
    {
        return _lengthInMinutes / GetDistance();
    }

    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_lengthInMinutes} min) - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km"; //{GetType().Name} is turning the class name to a string here.
    }
} 
 