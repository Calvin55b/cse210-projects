using System;
using System.IO;
using System.IO.Enumeration;
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



            Console.Write("Select a choice from the menu: ");
            Console.WriteLine();
            int userChoice = int.Parse(Console.ReadLine());


            if (userChoice == 1)
            {
                //Create New Goal



                goalManager.makeGoal();


            }


            if (userChoice == 2)
            {

                //List Goals//

                Console.WriteLine("The goals are:\n");


                foreach (SimpleGoal g in goalManager.GetGoals())
                {

                    Console.WriteLine($"[] {g.GetGoalType()} {g.GetName()} - {g.GetDescription()}");



                }


                Console.WriteLine($"You have {goalManager.GetTotalPoints()} points.\n");



            }

            if (userChoice == 3)
            {

                //Save Goals//

                Console.Write("What would you like to save your file as? ");

                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (SimpleGoal g in goalManager.GetGoals())
                    {

                        outputFile.WriteLine(g.ToString());
                    }

                }




            }
            if (userChoice == 4)
            {

                //Load Goals//

                Console.Write("What file would you like to load? ");

                string userFile = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(userFile);

                foreach (string line in lines)
                {

                    // Goal type//
                    string[] parts = line.Split(":");

                    string goalType = parts[0];
                    string goalData = parts[1];


                    // goal Attributes

                    string[] attributes = line.Split(",");



                    if (goalType == "Simple Goal")
                    {

                        string name = attributes[0];
                        string description = attributes[1];
                        string points = attributes[2];
                        string done = attributes[3];




                        SimpleGoal simpleGoal = new SimpleGoal(name, description, int.Parse(points));

                        if (done == "true")

                        {

                            simpleGoal.SetDone();



                        }

                          goalManager.LoadGoal(simpleGoal);
                    }

                    else if (goalType == "Eternal Goal")
                    {
                        
                        string name = attributes[0];
                        string description = attributes[1];
                        string points = attributes[2];
                        string done = attributes[3];
                        


                        SimpleGoal eternalGoal = new SimpleGoal(name, description, int.Parse(points));

                        if (done == "true")
                        {
                            eternalGoal.SetDone();
                        }

                        goalManager.LoadGoal(eternalGoal);


                    }

                    else if ( goalType == "Check List Goal")
                    {
                        
                        string name = attributes[0];
                        string description = attributes[1];
                        string points = attributes[2];
                        string bonusPoints = attributes[3];
                        string goalOfCompletions = attributes[4];

                        // I need to figure out a way to change the number of times a goal was completed. I think I need to do this in the record section but I also need a way to load that recorded event.
                        string done = attributes[6];
                    




                    }

                    else
                    {


                    Console.WriteLine("An error occured");

                    }


                  






                }



            }
            if (userChoice == 5)
            {
                int counter = 0;
                //Record Event//
                foreach (SimpleGoal simpleGoal in goalManager.GetGoals())
                {
                    
                    Console.Write($"{++counter}:");
                    simpleGoal.DisplayName();

                }

                Console.Write("What goal did you complete? ");

                string completedChoice = Console.ReadLine();

                int index = int.Parse(completedChoice);

               SimpleGoal achievedGoal = goalManager.GetGoals() [index-1];

               int score =  achievedGoal.CompleteGoal();


               goalManager.AddPoint(score);





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