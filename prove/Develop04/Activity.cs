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

    }

    public void DisplayEndMessage()
    {

    }

    public void Spinner()
    {

    }
}
