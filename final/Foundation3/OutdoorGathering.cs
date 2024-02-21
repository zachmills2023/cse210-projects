using System;

public class OutdoorGathering : Event
{
    private string _weather;
    public OutdoorGathering(string title,string description,DateTime date,
    TimeSpan time,Address address,string weather) :
    base(title,description,date,time,address)
    {
        _weather = weather;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather: {_weather}";
    }

    public string GetShortDescription()
    {
        return $"Outdoor Gathering: {_title} on {_date.ToShortDateString()}";
    }

}