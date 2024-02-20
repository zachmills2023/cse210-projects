using System;

public class Comments
{
    private string _name;
    private string _text;

    public Comments(string name,string text)
    {
        _name = name;
        _text = text;
    }

    public string GetCommentDetails()
    {
        return$"{_name}\n{_text}";
    }
}