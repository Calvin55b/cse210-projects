using System;

class Program
{
    static void Main(string[] args)
    {
        string userOption = "";

        while(userOption != "4")
        {
            Console.WriteLine("Menu Options:");

            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu:");

            userOption = Console.ReadLine();

            if (userOption == "1")
            {
                Console.Clear();

                Console.Write("Welcome to the ");
                 Breathing breathing = new Breathing();

                breathing.RunBegin();

                //Move to the get ready stage

                Console.Clear();

                Console.WriteLine("Getting ready....");

                Timer timer = new Timer();

                timer.PauseWithAnimation();

                // How would i continue to loop thorugh all of the breathing for the given user number?

                /*while(timer.IsExpired(breathing) != 0)
                {
                    
                }
                */
                breathing.RunBreathing();
                

                breathing.RunEnd();

                timer.PauseWithAnimation();

                Console.Clear();


            }
            
            else if (userOption == "2")
            {

                Console.Clear();

                Console.Write("Welcome to the ");
                 Reflection reflection = new Reflection();

                reflection.RunBegin();

                //Move to the get ready stage

                Console.Clear();

                Console.WriteLine("Getting ready....");

                Timer timer = new Timer();

                timer.PauseWithAnimation();

                reflection.displayRandomPrompt();

                Console.WriteLine(@"Now ponder on each of the following questions as they related to this experience.");

                Console.Write("You may begin in: ");
                timer.TimerToBegin();

                Console.Clear();

                //I need to find a way to display each Question for a given amount of time and then move on to the next depending on how much time the user has for the activity.

                reflection.displayQuestion();

                timer.PauseWithAnimation();




               


                reflection.RunEnd();

                timer.PauseWithAnimation();

                Console.Clear();

                


                
            }
            else if (userOption == "3")
            {
                Console.Clear();

                Console.Write("Welcome to the ");
                 Listing listing = new Listing();

                listing.RunBegin();

                //Move to the get ready stage

                Console.Clear();

                Console.WriteLine("Getting ready....");

                Timer timer = new Timer();

                timer.PauseWithAnimation();

                listing.DisplayPrompt();

                listing.UserEntries();



                listing.RunEnd();

                timer.PauseWithAnimation();


                Console.Clear();

                



            }
            else if (userOption == "4")
            {

                Console.WriteLine("Thank you for using the mindfulness program!");
                



            }
            else
            {
                Console.WriteLine("Invalid choice, please try again. ");
                



            }











        }


        //this initializes the title,desc, of the breathing activity.

       


        
        //timer.IsExpired(breathing);


        //this runs the animation for getting ready
        /* Timer timer = new Timer();

         timer.PauseWithAnimation();

         */



    


    }
}