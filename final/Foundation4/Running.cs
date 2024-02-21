using System;

public class Running : Activity
{
    private double _distanceMiles;

    public Running(DateTime date,int lengthMinutes,double distanceMiles)
    : base(date,lengthMinutes)
    {
        _distanceMiles = distanceMiles;
    }

    public override double GetDistance()
    {
        return _distanceMiles;
    }

    public override double GetSpeed()
    {
        return _distanceMiles / (_lengthMinutes / 60.0);
    }

    public override double GetPace()
    {
        return _lengthMinutes / _distanceMiles;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}\nType: Running \nDistance {_distanceMiles} miles," + 
        "\nSpeed {GetSpeed():F2} mph, \nPace: {GetPace():F2} min per mile\n";
    }
}