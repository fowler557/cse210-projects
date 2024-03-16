public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _timesToComplete;

    public ChecklistGoal(string goalName, string goalDescription, int goalNumber, string goalType, int goalPoints) : base(goalName, goalDescription, goalNumber, goalType,goalPoints)
    {
        
    }

}