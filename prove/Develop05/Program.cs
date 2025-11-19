using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Menu Options:
        1. Create New Goal
        2. List Goals
        3. Save Goals
        4. Load Goals
        5. Record Event
        6.Quit");

      

        Console.Write("Select a choice from the menu:");

       string userChoice = Console.ReadLine();

       
        // if (userChoice == "1")
        // {
        //     Console.WriteLine(@"The types of Goals are:
        //         1. Simple Goal
        //         2. Eternal Goal
        //         3. Checklist Goal");

        //         Console.Write("Which type of goal would you like to create?");


        //        string typeOfGoal =Console.ReadLine();

               ListOfGoals newGoal = new ListOfGoals();

               newGoal.makeGoal();
           








    }
    
}