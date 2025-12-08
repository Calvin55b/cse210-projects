public class Outdoor : Event
{
    private string _weather;
 public Outdoor(string title, string description, Address address,DateOnly date, TimeOnly time, string weather) 
    : base(title, description, address, date, time)
    {
        _weather = weather;
    }


     public override string GetEventType()
    {
        return "Outdoor";
    }

    public override string GetStandardDetails()
    {
        return base.GetStandardDetails();
    }

    public override string GetShortDescription()
    {
        return base.GetShortDescription();
    }

    public override string GetEventSpecific()
    {
        return $"RSVP Email: {_weather}";
    }

    public override string GetFullDetails()
    {
        return $"Standard Deets:{GetStandardDetails()}\n Specific Deets: {GetEventSpecific()}";
    }


}