public class Receptions : Event
{
    private string _rsvp;

 public Receptions(string title, string description, Address address,DateOnly date, TimeOnly time, string rsvp) 
    : base(title, description, address, date, time)
    {
        _rsvp = rsvp;
    }

    public override string GetEventType()
    {
        return "Reception";
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
        return $"RSVP Email: {_rsvp}";
    }

    public override string GetFullDetails()
    {
        return $"Standard Deets:{GetStandardDetails()}\n Specific Deets: {GetEventSpecific()}";
    }






}