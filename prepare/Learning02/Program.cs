using System;
using System.Threading.Tasks.Dataflow;


class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Mapbox";
        job1._startYear = 2018;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "GIS AR Software Developer";
        job2._company = "Esri";
        job2._startYear = 2012;
        job2._endYear = 2018;

        Resume myResume = new Resume();
        myResume._name = "Jedadiah Jacobs";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}