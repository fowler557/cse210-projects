using System.Security.Cryptography.X509Certificates;

public class Goal
{
    private string _goalName;
    private string _goalDescription;
    private int _goalNumber;
    private string _goalType;
    private int _goalPoints;
    private bool _isComplete;

    public Goal(string goalName, string goalDescription, int goalNumber, string goalType, int goalPoints)  //constructer that takes in all the parameters
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _goalNumber = goalNumber;
        _goalType = goalType;
        _goalPoints = goalPoints;

        
    }


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


    public int GetGoalNumber()  //gets the number of the goal
    {
        return _goalNumber;
    }


    public void SetGoalNumber(int goalNumber)  //sets the number of the goal
    {
        _goalNumber = goalNumber;
    }


    public string GetGoalType()  //gets the type of the goal
    {
        return _goalType;
    }


    public void SetGoalType(string goalType)  //sets the type of the goal
    {
        _goalType = goalType;
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


}