public abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private Address _address;

    public Event(string title, string description, DateTime date, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _address = address;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public string GetStandardDetails()
    {
        return $"{_title} - {_description}. When: {_date.ToString("MMMM dd, yyyy HH:mm")}. Where: {_address.ToString()}";
    }

    public abstract string GetFullDetails();

    public string GetShortDescription()
    {
        return $"{GetType().Name} - {_title} on {_date.ToString("MMMM dd, yyyy")}";//$"{GetType().Name}" will give the class name as a string
    }
}
 