using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Xml.Linq;





class Programm
{
    static void Main(string[] args)
    {
        /*Programm myObject = new Programm();*/
        Journal entriesList = new Journal();


        while (true)
        {

            Console.WriteLine("Welcome to the Journal Program! ");
            Console.WriteLine("Please select one of the following choices ");
            Console.WriteLine("1) Write"); // This will allow you to write a new entry. It will also add a date without the users knowledge and will prompt you for a journal entry.
            Console.WriteLine("2) Display");// Will show all the entries in your journal. Adding the date to the entry. This is just for the current entries that are not saved.
            Console.WriteLine("3) Load");// This will ask the user for which saved journal file they want to see.
            Console.WriteLine("4) Save");// This prompts the user for a fileName to save the file to.
            Console.WriteLine("5) Quit");// This ends the loop.
            Console.Write("What would you like to do? ");
            
            int userChoise = int.Parse(Console.ReadLine());

            if (userChoise == 1)
            {



                Entry myEntry = new Entry();
                myEntry.Write();
                // {

                //     myEntry._dateTime = "";
                //     myEntry._entryName = "General Conference";
                //     myEntry._userEntry = "Today I went to General Conference. It was an awesome experience and I was able to grow closer to the Lord.";
                // }


                entriesList._entriesList.Add(myEntry);
            }

            //     foreach (Entry i in _entriesList)
            //     {
            //         i.displayEntry();
            //     }
            // }
            else if (userChoise == 2)
            {
                entriesList.DisplayAllEntries();


                // Option 2 code here
            }
            else if (userChoise == 3)
            {
                entriesList.displayFile();
                // Option 3 code here
            }
            else if (userChoise == 4)
            {
                    entriesList.Save();
                // Option 4 code here
            }
            else
            {
                break;
            }

        }
    }
}











