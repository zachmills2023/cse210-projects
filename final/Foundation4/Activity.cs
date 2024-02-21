using System;

public class Activity
{
    protected DateTime _date;
    protected int _lengthMinutes;

    public Activity(DateTime date,int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date.ToString("dd MM yyyy")}({_lengthMinutes})";
    }
}