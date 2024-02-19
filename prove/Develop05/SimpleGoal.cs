using System;

public class SimpleGoal : Goal
{
    bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name,description,points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public override void RecordEvent(List<Goal> GoalList,GoalManager GM,int choice)
    {
        base.RecordEvent(GoalList,GM,choice); // Call the parent class's version of the method
        _isComplete = true; // Mark the goal as complete
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        if (_isComplete)
        {
            return $"[X] {_shortName} ({_description})";
        }
        else
        {
            return base.GetDetailsString();
        }
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName}:{_description}:{_points}:{_isComplete}";
    }
}