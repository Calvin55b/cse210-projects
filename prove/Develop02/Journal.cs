using System.IO;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;
public class Journal


{

    public List<Entry> _entriesList = new List<Entry>();

    public void DisplayAllEntries()
    {
        foreach (Entry entry in _entriesList)
        {
            entry.DisplayEntry();
        }
    }
    //save//
    public void Save()
    {

        // I would use this code to read a code depending on user inputstring filename = Console.ReadLine(save);//
        Console.Write("What file would you like to save your entry to? ");
        string fileName =Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry e in _entriesList)
            {
                outputFile.WriteLine($"{e._dateTime} ~{e._prompt}~{e._userEntry}");
            }
        }

        Console.WriteLine($"Your file was successfully saved to {fileName}");


    }

    //Write//




    //Display saved files//

    public void displayFile()
    {
        Console.Write("What file do you want to load?");

        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] breakInFile = line.Split("~");

            string _dateTime = breakInFile[0];

            string _prompt = breakInFile[1];

            string _userEntry = breakInFile[2];

            Console.WriteLine($"{_dateTime} {_prompt} {_userEntry}");

            Console.WriteLine("Your file was successfully loaded!");

        }

    }











}