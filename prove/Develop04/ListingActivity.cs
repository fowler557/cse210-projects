public class ListingActivity : Activity
{
    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void DisplayListingPrompt()
    {
        ListingPromptGenerator listingPromptGenerator = new ListingPromptGenerator();
        string listingPrompt = listingPromptGenerator.GetRandomPrompt();
        Console.Clear();
        Console.Write($"List as many responses you can to the following prompt:\n---{listingPrompt}---\nYou may begin in:");
        Timer(5);
    }
    
    public void UserList()
    {   
        int count = 0;
        Console.Write("\n\n");
        int duration = GetDuration();
        
        DateTime StartTime = DateTime.Now;
        DateTime EndTime = StartTime.AddSeconds(duration);

        while (DateTime.Now < EndTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count ++;
        }
        Console.Write($"\nYou listed {count} items!");
        Spinner(5);
    }

}