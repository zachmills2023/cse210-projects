using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the event objects in.
        List<Event> events = new();

        // Create the event objects and add them to a list.
        Lecture lecture = new Lecture("Lecture on mapping global climate change", "An in-depth look at Global Climate Change through Geoanalysis.", 
        DateTime.Today, TimeSpan.FromHours(14), new Address("1240", "Abbey Road", "Liverpool", "London"), "Paul Mcartney", 100);
        events.Add(lecture);

        Reception reception = new Reception("Company Reception", "A reception for all company employees", 
        DateTime.Today.AddDays(1), TimeSpan.FromHours(18), new Address("1617 Birch Road", "Ann Arbor", "MI", "USA"), "rsvp@company.com");
        events.Add(reception);

        OutdoorGathering gathering = new OutdoorGathering("Company Picnic", "A picnic for all company employees", 
        DateTime.Today.AddDays(2), TimeSpan.FromHours(12), new Address("1415 Cedar Boulevard", "Asheville", "NC", "USA"), "Partly Cloudy");
        events.Add(gathering);

        // Display the information for each event use "var" type to simplify since there are multiple kinds of objects. 
        foreach (var evt in events)
        {
            // List the standard details first, as they are not specific to any of the given objects.
            Console.WriteLine("Standard Details:");
            Console.WriteLine(evt.GetStandardDetails());
            Console.WriteLine();

            // Use type checking -- "is (object type)" -- to call the correct method:
            if (evt is Lecture lectureEvent)
            {
                Console.WriteLine("Full Details:");
                Console.WriteLine(lectureEvent.GetFullDetails());
                Console.WriteLine();

                Console.WriteLine("Short Description:");
                Console.WriteLine(lectureEvent.GetShortDescription());
                Console.WriteLine();
            }
            else if (evt is Reception receptionEvent)
            {
                Console.WriteLine("Full Details:");
                Console.WriteLine(receptionEvent.GetFullDetails());
                Console.WriteLine();

                Console.WriteLine("Short Description:");
                Console.WriteLine(receptionEvent.GetShortDescription());
                Console.WriteLine();
            }
            else if (evt is OutdoorGathering gatheringEvent)
            {
                Console.WriteLine("Full Details:");
                Console.WriteLine(gatheringEvent.GetFullDetails());
                Console.WriteLine();

                Console.WriteLine("Short Description:");
                Console.WriteLine(gatheringEvent.GetShortDescription());
                Console.WriteLine();
            }
        }
    }
}