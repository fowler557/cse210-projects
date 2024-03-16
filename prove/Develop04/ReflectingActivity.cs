public class ReflectingActivity : Activity
{
    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        
    }

    public void DisplayReflectingPrompt()
    {
        ReflectingPromptGenerator reflectingPromptGenerator = new ReflectingPromptGenerator();
        string reflectingPrompt = reflectingPromptGenerator.GetRandomPrompt();
        Console.Clear();
        Console.Write($"Consider the following prompt\n\n---{reflectingPrompt}---\n\nWhen you have something in mind, press enter to continue\n");
        Console.ReadLine();
    }

    public void DisplayQuestionPrompt()
    {
        ReflectingPromptGenerator reflectingPromptGenerator = new ReflectingPromptGenerator();
        string quesionPrompt = reflectingPromptGenerator.GetRandomQuestionPrompt();
        Console.Write($"\nNow ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
        Timer(5);
        Console.Clear();
        int questionDuration = GetDuration()/2;
        Console.WriteLine($"> {quesionPrompt}");
        Spinner(questionDuration);
        Console.WriteLine($"\n\n>{quesionPrompt}");
        Spinner(questionDuration);
    }
}