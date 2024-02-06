using System;

public class MathAssignment : Assignment{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName,string topic,string problems,string textbookSection) : base(studentName,topic){
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList(){
        return $"\n{GetSummary()} {_textbookSection} {_problems}";
    }
}