public class Comments
{
    

private string _creator;


private string _commentText;

 
public Comments(string creator, string comment)
    {
        
    _creator = creator;

    _commentText = comment;



    }


public string Creator()
    {
        
        return _creator;
        
    }
public string Comment()
    {
        
        return _commentText;

    }

}