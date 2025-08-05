using System;

public class Book
{
    public string Title;
    public string Author;
    public int PageCount;
    public bool IsRead;

    public string GetInfo()
    {
        return "Title: " + Title + Environment.NewLine +
               "Author: " + Author + Environment.NewLine +
               "Pages: " + PageCount + Environment.NewLine +
               "Read: " + (IsRead ? "Yes" : "No");
    }
}
