using System.Globalization;
namespace calendar_events;

public class Event : IEvent
{
    public string? Title {get; set; }
    public DateTime EventDate {get; set; }
    public string? Description {get; set; }
        

    public Event(string title, string date, string description)
    {
        Title = title;
        var dateArray = date.Split('-');
        EventDate = new DateTime(Convert.ToInt32(dateArray[0]), Convert.ToInt32(dateArray[1]), Convert.ToInt32(dateArray[2]));
        Description = description;
    }

    public Event(string title, string date)
    {
        Title = title;
        var dateArray = date.Split('-');
        EventDate = new DateTime(Convert.ToInt32(dateArray[0]), Convert.ToInt32(dateArray[1]), Convert.ToInt32(dateArray[2])); 
    }

    public void DelayDate(int days)
    {
        EventDate = EventDate.AddDays(days);
    }

    public string PrintEvent(string format)
    {
        string dateString = EventDate.ToString("d");
        if(format == "normal") return $"Evento = {Title}\nDate = {dateString}\n";
        if(format == "detailed") return $"Evento = {Title}\nDate = {dateString}\nDescription = {Description}";
        return "Invalid Format";      
    }
}
