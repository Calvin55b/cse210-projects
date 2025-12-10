public class Video
{
    
private string _title;

private string _author;

private int _length;

private List<Comments> _comment= new List<Comments>();


    public void SetVideoDescription(string title , string author , int length)
    {
        
        _title = title;

        _author = author;

        _length = length;
    

    }

    public void AddComment(string creator, string comment)
    {
        
        Comments c = new Comments(creator, comment);

        _comment.Add(c);

    }

    public void Display()
    {
        

        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Video Length: {_length} (Seconds)");

        Console.WriteLine();
        Console.WriteLine("Comments: ");



        foreach ( Comments c in _comment)
        {
            


            Console.WriteLine($"{c.Creator()}, {c.Comment()}");


        }


    }

}