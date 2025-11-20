using System;

class Program
{
    static void Main(string[] args)
    {
        bool run = true;

        ListOfGoals goalManager = new ListOfGoals();

    while (run)
    {



      
        
        Console.WriteLine(@"Menu Options:
        1. Create New Goal
        2. List Goals
        3. Save Goals
        4. Load Goals
        5. Record Event
        6.Quit");

      

        Console.Write("Select a choice from the menu:\n");

       int userChoice = int.Parse(Console.ReadLine());

       
        if (userChoice == 1)
        {
            //Create New Goal

               ListOfGoals newGoal = new ListOfGoals();

               newGoal.makeGoal();


        }


        if (userChoice == 2)
        {
            
            //List Goals//





        }

        if (userChoice == 3)
        {
            
            //Save Goals//





        }
        if (userChoice == 4)
        {
            
            //Load Goals//





        }
        if (userChoice == 5)
        {
            
            //Record Event//





        }

        if (userChoice == 6)
        {
            

            Console.WriteLine("Shuting down .......");
             run = false;
        }

        if (userChoice > 6)
        {

            Console.WriteLine("Invalid option. Try agin. \n");
        }
    }




           








    }
    
}