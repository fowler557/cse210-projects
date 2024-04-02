public class SimpleGoal : Goal
{
    public SimpleGoal(string goalName, string goalDescription, int goalPoints, bool isComplete) : base(goalName, goalDescription, goalPoints, isComplete)
    {}

    public override string SeparateGoal()
    {
        return $"SimpleGoal:{GetGoalName()},{GetGoalDescription()},{GetGoalPoints()},{GetCompleted()},";
    }

}