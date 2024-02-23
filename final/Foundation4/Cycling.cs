using System;

public class Cycling : Activity
{
    double _speedMPH;

    public Cycling(DateTime date,int lengthMinutes,double speedMPH) : base(date,lengthMinutes)
    {
        _speedMPH = speedMPH;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}\nType: Cycling\nSpeed: {_speedMPH} mph\nDistance: " + GetDistance()
        + " miles\nPace: " + GetPace() + "min per mile\n";
    }

    public override double GetDistance()
    {
        // Speed times time and make the minutes divided by 60 so that it is per hour. 
        return _speedMPH * (_lengthMinutes / 60.0);
    }

    public override double GetSpeed()
    {
        return _speedMPH;
    }

    public override double GetPace()
    {
        return _lengthMinutes / GetDistance();
    }
}