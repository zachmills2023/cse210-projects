using System;

public class Reception : Event
{
    private string _rsvp;

    public Reception(string title,string description,DateTime date,TimeSpan time,
    Address address,string rsvp) : base(title,description,date,time,address)
    {
        _rsvp = rsvp;
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Reception\nRSVP Email: {_rsvp}";
    }

    public string GetShortDescription()
    {
        return $"Reception: {_title} on {_date.ToShortDateString()}";
    }
}