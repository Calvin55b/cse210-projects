class Word
{
    //Attribuites
    private string _word;


   private bool _revealed;

    // Behaviors
    public Word(string w) // Constructor
    {
        _word = w;

        _revealed = true;
    }


    public void Display()
    {
        if (_revealed)
        {
            Console.Write(" "+_word);

        }

        else
        {
            
            Console.Write("_____");
        }
    }

    public void Hide() //Setter
    {
        _revealed = false;
    }
    
    public bool IsRevealed() //Getter
    {
        return _revealed;
    }
}