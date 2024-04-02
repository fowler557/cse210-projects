using System.Runtime.CompilerServices;

public abstract class Goal
{
    
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;
    private bool _isComplete;

    public Goal(string goalName, string goalDescription, int goalPoints, bool isComplete)  //constructer that takes in all the parameters
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalPoints = goalPoints;
        _isComplete = isComplete;

        
    }

    public virtual void CreateGoal()  //creates the goal
    {
        Console.Clear();
        Console.Write("What is the name of your goal? ");
        SetGoalName(Console.ReadLine());
        Console.Write("Type a short description of it: ");
        SetGoalDescription(Console.ReadLine());
        Console.Write("How many points is this goal worth? ");
        SetGoalPoints(int.Parse(Console.ReadLine()));
    }

    public virtual string GoalStatus()  //returns the status of the goal
    {
        if (GetCompleted() == true)
        {
            return $"[X] {GetGoalName()} ({GetGoalDescription()})";
        }
        else
        {
            return $"[ ] {GetGoalName()} ({GetGoalDescription()})";
        }
    }

    public abstract string SeparateGoal();


    public string GetGoalName()    //gets the name of the goal
    {
        return _goalName;
    }


    public void SetGoalName(string goalName)  //sets the name of the goal
    {
        _goalName = goalName;
    }


    public string GetGoalDescription()  //gets the description of the goal
    {
        return _goalDescription;
    }


    public void SetGoalDescription(string goalDescription)  //sets the description of the goal
    {
        _goalDescription = goalDescription;
    }


    public int GetGoalPoints()  //gets the points of the goal
    {
        return _goalPoints;
    }


    public void SetGoalPoints(int goalPoints)  //sets the points of the goal
    {
        _goalPoints = goalPoints;
    }


    public bool GetCompleted()  //gets if the goal is completed
    {
        return _isComplete;
    }

    public void SetCompleted(bool isComplete)  //sets if the goal is completed
    {
        _isComplete = isComplete;
    }

    
}