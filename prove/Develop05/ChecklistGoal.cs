public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _bonus;
    private int _timesToComplete;

    public ChecklistGoal(string goalName, string goalDescription, int goalPoints, bool isComplete, int bonus, int timesToComplete, int timesCompleted) : base(goalName, goalDescription, goalPoints, isComplete)
    {
        _timesToComplete = timesToComplete;
        _bonus = bonus;
        _timesCompleted = timesCompleted;
        
    }

    public override void CreateGoal()
    {
        Console.Clear();
        Console.Write("What is the name of your goal? ");
        SetGoalName(Console.ReadLine());
        Console.Write("Type a short description of it: ");
        SetGoalDescription(Console.ReadLine());
        Console.Write("How many points is this goal worth? ");
        SetGoalPoints(int.Parse(Console.ReadLine()));
        Console.Write("How many times must this goal be completed to earn a bonus? ");
        SetTimesToComplete(int.Parse(Console.ReadLine()));
        Console.Write("How many points is a bonus worth? ");
        SetBonusPoints(int.Parse(Console.ReadLine()));
    }

    public override string GoalStatus() ///returns the status of the goal
    {
        if (GetCompleted() == true)
        {
            return $"[X] {GetGoalName()} ({GetGoalDescription()}) - Currently completed: {GetTimesCompleted()}/{GetTimesToComplete()}";

        }
        else
        {
            return $"[ ] {GetGoalName()} ({GetGoalDescription()}) - Currently completed: {GetTimesCompleted()}/{GetTimesToComplete()}";
        }
    }

    public override string SeparateGoal() //seperates the goal with comas as a string
    {
        return $"ChecklistGoal:{GetGoalName()},{GetGoalDescription()},{GetGoalPoints()},{GetCompleted()},{GetBonusPoints()},{GetTimesToComplete()},{GetTimesCompleted()},";
    }

    public int GetTimesToComplete() //gets the times to complete before bonus
    {
        return _timesToComplete;
    }

    public void SetTimesToComplete(int timesToComplete) //sets the times to complete before bonus
    {
        _timesToComplete = timesToComplete;
    }

    public int GetBonusPoints() //gets the bonus points
    {
        return _bonus;
    }

    public void SetBonusPoints(int bonus) //sets the bonus points
    {
        _bonus = bonus;
    }

    public int GetTimesCompleted() //gets the times completed
    {
        return _timesCompleted;
    }

    public void SetTimesCompleted(int timesCompleted) //sets the times completed
    {
        _timesCompleted = timesCompleted;
    }

}