public class Activity
{
    private string _name;
    private string _activityDescription;
    private int _duration;



    
    public Activity(string name, string activityDescription)
    {
        _name = name;
        _activityDescription = activityDescription;
        _duration = 10;
    }
    public Activity(string name, string activityDescription, int duration)
    {
        _name = name;
        _activityDescription = activityDescription;
        _duration = duration;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetActivityDescription()
    {
        return _activityDescription;
    }

    public void SetActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }
    
    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}!\n\n{_activityDescription}\n\nHow long, in seconds, would you like for your session?");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);
        Console.Clear();
        Console.WriteLine($"Get ready! ");
        Spinner(5);
    }

    public void DisplayEndMessage()
    {
        Console.Clear();
        Console.WriteLine($"Well done!");
        Spinner(3);
        Console.WriteLine($"\n\nYou have completed {_duration} seconds of the {_name}.");
        Spinner(5);
        Console.Clear();
    }

    public void Spinner(int seconds)
    {
        List<string> animation = new List<string>
        {
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\",
            "|"
        };
       
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animation[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animation.Count)
            {
                i = 0;
            }
        }

    }

    public void Timer(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
