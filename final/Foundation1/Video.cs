using System;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comments> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comments>();
    }

    public void AddComment(Comments comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentNumber()
    {
        return _comments.Count;
    }

    public string GetVideoDetails()
    {
        return $"Title: {_title}, Author: {_author}, Length: {_length} seconds";
    }

    public List<Comments> GetComments()
    {
        return _comments;
    }
}

