using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        //This is to incilize / test my word class
        //Word word1 = new Word("Jesus");

        //Word word2 = new Word("wept.");


        // word1.Display();
        //word2.Display();
        //word1.Hide();


        //initialize list


        /////////////////////////////
        /// 

        //attributes to agragate a reference with either one or two verses.

        /* Reference SingleVerse = new Reference();

        SingleVerse.MultiVerse("John", "3", "1","6");

        SingleVerse.Display();
        */

        // initialize Scripture//

        



        Reference reference = new Reference();
        
        reference.SingleVerse("Psalm", "34", "4");

        string  verseText = "I sought the Lord and he heard me and delivered me from all my fears.";

        List<Word> words = new List<Word>();

        foreach (string wordText in verseText.Split(' '))
        {
            words.Add(new Word(wordText));
            
        }



        Scripture display = new Scripture(reference, words);
        string userDecision = " ";
        


        while (userDecision != "quit")
        {
            Console.Clear();

            display.Display();

            Console.WriteLine();

            Console.WriteLine($"You memorized {display.Memorized()} words!");



            Console.Write("Press enter to continue or type 'quit' to finish:");

            int usedWords = display.ChosenCount();
            
        

            if (usedWords != display.WordCount())
            {

                userDecision = Console.ReadLine();


                display.HideRandom();
            }

            else
            {
                userDecision = "quit";
            }    

        }    


    }
}