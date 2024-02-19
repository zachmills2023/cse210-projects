using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name,string description,int points,int amountCompleted, int target,int bonus) : base(name,description,points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent(List<Goal> GoalList, GoalManager GM, int choice)
    {
        // Check if the goal was not complete before the event was recorded
        bool wasIncomplete = !IsComplete();

        base.RecordEvent(GoalList, GM, choice); // Call the parent class's version of the method

        // Increment the amount completed
        _amountCompleted++;

        // If the goal was incomplete and is now complete, add the bonus to the score
        if (wasIncomplete && IsComplete())
        {
            Console.WriteLine($"Congratulations! You earned {_bonus} bonus points!");
            
            int score = GM.GetScore();
            GM.SetScore(_bonus + score);
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        if(_amountCompleted >= _target)
        {
            return $"[X] {_shortName} ({_description}) with {_amountCompleted}/{_target} completed.";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) with {_amountCompleted}/{_target} completed.";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName}:{_description}:{_points}:{_amountCompleted}:{_target}:{_bonus}";
    }
}