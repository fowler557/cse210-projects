public class BreathingActivity : Activity
{
    
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void BreathOut()
    {
        Console.WriteLine("Breath out.");
    }

    public void BreathIn()
    {
        Console.WriteLine("Breath in.");
    }
}