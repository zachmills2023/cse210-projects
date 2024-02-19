using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name,string description,int points) : base(name,description,points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public override void RecordEvent(List<Goal> GoalList,GoalManager GM,int choice)
    {
        base.RecordEvent(GoalList,GM,choice);
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName}:{_description}:{_points}";
    }
}