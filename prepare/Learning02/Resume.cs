
using System;
using System.Threading.Tasks.Dataflow;

public class Resume{
    public string _name;

    //initialize list
    public List<Job> _jobs = new List<Job>();

    public void Display(){
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // 'job' is used as a custom data type below like strings or ints
        foreach (Job job in _jobs){
            // This will call the display method(which is just a function inside a class/object)
            job.Display();
        }
    }
}