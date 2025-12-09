public class Lectures : Event
{

    private string _speaker;


    private int _capacity;
    
    public Lectures(string title, string description, Address address,DateOnly date, TimeOnly time, string speaker, int capacity) 
    : base(title, description, address, date, time)
    {
        _speaker = speaker;

        _capacity = capacity;
    }


    public override string GetEventType()
    {
        return "Lecture";
    }

    public override string GetShortDescription()
    {
        return base.GetShortDescription();
    }

    public override string GetStandardDetails()
    {
        return base.GetStandardDetails();
    }

    public override string GetEventSpecific()
    {
        return $"Speaker: {_speaker}\n Capacity: {_capacity}";
    }


    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\n {GetEventSpecific()}";
    }

    

}