using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

class Scripture



{
    //Attributes//

    private Reference _reference;

    private List<Word> _listOfWords;





    //Constructor
    
    public Scripture(Reference reference, List<Word> verse) 
    {
        _reference = reference;

        _listOfWords = verse;



    }

    //Behaviors//
    public void Display()
    {

        _reference.Display();

        foreach (Word i in _listOfWords)
        {
            i.Display();
        }


    }

    public void HideRandom()
    {
        Random random = new Random();

        int ranNum = random.Next(0, WordCount());

        _listOfWords[ranNum].Hide();





    }

    public int WordCount()
    {

        int numOfWords = _listOfWords.Count;

        return numOfWords;



    }
    
    public int ChosenCount()
    {
        int wordChosen = 0;

        foreach (Word i in _listOfWords)
        {
            if (i.IsRevealed() != true)
            {
                wordChosen += 1;
            }
        }

        return wordChosen;
    }
    
    
}