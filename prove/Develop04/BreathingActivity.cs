public class BreathingActivity : Activity
{
    
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
       
    }
 
    public void BreathInBreathOut()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        Thread.Sleep(3000);

        while (futureTime > DateTime.Now)
        {
            Console.WriteLine("Breath in.");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("Breath out.");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }
}