public class EternalGoal : Goal
{
    public EternalGoal(string goalName, string goalDescription, int goalPoints, bool isComplete) : base(goalName, goalDescription, goalPoints, isComplete)
    {}

    public override string SeparateGoal() //seperates the goal with comas as a string
    {
        return $"EternalGoal:{GetGoalName()},{GetGoalDescription()},{GetGoalPoints()},";
    }
} 