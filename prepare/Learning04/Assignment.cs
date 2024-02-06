using System;

public class Assignment
{
    protected string _studentName;
    private string _topic;
    
    // Constructor that creates empty string variables for a new object of Assignment.
    public Assignment(string studentName,string topic){
        _studentName = studentName;
        _topic = topic;
    }

    // public string GetTopic(){
    //     return _topic;
    // }
    // public string GetStudentName(){
    //     return _studentName;
    // }
    // public void SetStudentName(string studentName){
    //     string _studentName = studentName;
    // }
    // public void SetTopic(string topic){
    //     string _topic = topic;
    // }

    // Use this to get the summary of the student. 
    public string GetSummary(){
        return $"\n{_studentName} - {_topic}.";
    }
}