using System;

public class Swimming : Activity
{
    private int _lapNum;

    public Swimming(DateTime date,int lengthMinutes,int lapNum) : base(date,lengthMinutes)
    {
        _lapNum = lapNum;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}\nType: Swimming\nNumber of Laps: {_lapNum}\nDistance: {GetDistance():F2} miles\nSpeed:" +
         $"{GetSpeed():F2} mph\nPace: {GetPace():F2} min per mile\n";    
    }

    public override double GetDistance()
    {
        return _lapNum * 50 / 1609.34;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _lengthMinutes) * 60;
    }

    public override double GetPace()
    {
        return _lengthMinutes / GetDistance();
    }
}