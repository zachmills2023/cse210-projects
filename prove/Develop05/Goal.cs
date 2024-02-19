using System;

public class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent(List<Goal> GoalList, GoalManager GM, int choice)
    {
        // choice is within the range of the list's count
        // Subtract 1 from choice because list indices start at 0
        Goal selectedGoal = GoalList[choice];

        Console.WriteLine($"Congratulations! You have earned {selectedGoal._points} points.");

        // Update the score based on the points added from the completed goal.
        int score = GM.GetScore();
        GM.SetScore(selectedGoal._points + score);
    }


    public string GetName
    {
        get { return _shortName; }
    }

    public virtual bool IsComplete()
    {
        return true;
    }

    public virtual string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description})";
    }

    public virtual string GetStringRepresentation()
    {
        return $"";
    }

}