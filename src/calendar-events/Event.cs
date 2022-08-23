using System.Globalization;
namespace calendar_events;

public class Event : IEvent
{
    public string? Title {get; set; }
    public DateTime EventDate {get; set; }
    public string? Description {get; set; }
        

    public Event(string title, string date, string description)
    {
        throw new NotImplementedException();
    }

    public Event(string title, string date)
    {
        throw new NotImplementedException();  
    }

    public void DelayDate(int days)
    {
        throw new NotImplementedException();
    }

    public string PrintEvent(string format)
    {
        throw new NotImplementedException();      
    }
}
