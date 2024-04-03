public class Reception : Event
{
    private string _emailForRSVP;

    public Reception(string title, string description, DateTime date, Address address, string emailForRSVP)
        : base(title, description, date, address)
    {
        _emailForRSVP = emailForRSVP;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()} RSVP at: {_emailForRSVP}.";
    }
}  