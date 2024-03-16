public class BreathingActivity : Activity
{
    
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
       
    }
 
    public void BreathInBreathOut()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        // Thread.Sleep(3000);

        while (futureTime > DateTime.Now)
        {
            Console.Write("\n\nBreath in...");
            Timer(4);
            Console.Write("\nBreath out...");
            Timer(6);
           
        }
    }
}