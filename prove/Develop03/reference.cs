class Reference
{
    //Attribuites//

    private string _book;


    private string _chapter;


    private string _startVerse;


    private string _endVerse;

    private bool _multipleVerses;

    //constructor//

    /*public Reference(string ReferenceVariable)
    {
        ReferenceVariable = 
    }
    */


    // behaviors //


    public void SingleVerse(string book, string chapter, string StartVerse )
    {
        _book = book;

        _chapter = chapter;

        _startVerse = StartVerse;

        _multipleVerses = false;


    }

    public void MultiVerse(string book, string chapter, string StartVerse, string EndVerse)
    {
         _book = book;

        _chapter = chapter;

        _startVerse = StartVerse;

        _endVerse = EndVerse;

        _multipleVerses = true;
        

    }

    public void Display()

    {
        if (_multipleVerses)
        {
            //_multipleVerses verses
            Console.Write($"{_book} {_chapter}:{_startVerse}-{_endVerse} ");

        }

        else
        {
            //single verse
        Console.Write($"{_book} {_chapter}:{_startVerse} ");
            
        }
        
        
    }
    
    
}