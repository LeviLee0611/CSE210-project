using System;

class Program
{
    static void Main(string[] args)
    {
        var lectureEvent = new LectureEvent("CSE210", "Lecture Description", DateTime.Now, TimeSpan.FromHours(2),
            new Address("123 Main St", "Rexburg", "ID", "USA"), "Levi Lee", 50);

        var receptionEvent = new ReceptionEvent("Dinner and dancing to follow", "Reception Description", DateTime.Now, TimeSpan.FromHours(3),
            new Address("546 Inl St", "Rexburg", "ID", "USA"), "rsvp@example.com");

        var indoorGatheringEvent = new indoorGatheringEvent("indoor Gathering Title", "indoor Gathering Description", DateTime.Now,
            TimeSpan.FromHours(4), new Address("I-Center", "Rexburg", "ID", "USA"), "Sunny");

        
        Console.WriteLine("Lecture Event:");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine();


        Console.WriteLine("Reception Event:");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine();


        Console.WriteLine("indoor Gathering Event:");
        Console.WriteLine(indoorGatheringEvent.GetStandardDetails());
        Console.WriteLine(indoorGatheringEvent.GetFullDetails());
        Console.WriteLine(indoorGatheringEvent.GetShortDescription());
    }
    }



public class LectureEvent : Event
{
    private string speaker;
    private int capacity;

    public LectureEvent(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Lecture\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
}


public class ReceptionEvent : Event
{
    private string rsvpEmail;

    public ReceptionEvent(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {rsvpEmail}";
    }
}

public class Event
{
    private string title;
    private string description;
    private DateTime date;
    private TimeSpan time;
    private Address address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time.ToString()}\nAddress: {address.ToString()}";
    }

    public virtual string GetShortDescription()
    {
        return $"Type: Event\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }
}


public class indoorGatheringEvent : Event
{
    private string weatherForecast;

    public indoorGatheringEvent(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: indoor Gathering\nWeather Forecast: {weatherForecast}";
    }
}


public class Address
{
    private string street;

    private string city;

    private string state;

    private string country;


    public Address(string street, string city, string state, string country)
    {
        this.street = street;

        this.city = city;

        this.state = state;

        this.country = country;
    }

    public override string ToString()
    {
        return $"{street}, {city}, {state}, {country}";
    }
}