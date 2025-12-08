public class Event
{
    
    // My understanding is that the title is like " Johns wedding" It is a title of a specific type of event.
    private string _title;

    private string _description;

    private DateOnly _date;

    private TimeOnly _time;

    private Address _address;

    // private string _extraDetails;


   public Event(string title, string description, Address address,DateOnly date, TimeOnly time)
    {
        

        _title = title;

        _description = description;

        _address = address;

        _date = date;

        _time = time;

        
    }

    public virtual string GetStandardDetails()
    {
        
        return $"Title: {_title}\n Description: {_description}\n Address: {_address}\n Date: {_date}\n Time: {_time}";

    }

    public virtual string GetShortDescription()
    {
        return $"Event: {GetEventType()}\n Title: {_title}\n Date: {_date}";

    }

    public virtual string GetEventType()
    {
        
        return "General Event";
    }


  //All of the events have a string for the full details. However, the lecture class needs to return the capcity of the event as well.
    public virtual string GetEventSpecific()
    {
        
        return "";
        

    }     

    public virtual string GetFullDetails()
    {
        return $"Standard Deets:{GetStandardDetails()}\n Specific Deets: {GetEventSpecific()}";


    }









}