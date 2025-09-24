using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        
        

        Random randomGenerator = new Random();
        int ranNumber = randomGenerator.Next(1, 11);

        int usersGuess = -1;

        
        while (usersGuess != ranNumber)
        {
            Console.Write("What is your guess? ");
            usersGuess = int.Parse(Console.ReadLine());
    

            if (usersGuess < ranNumber)
            {
                Console.WriteLine("Higher");
                

            }

            else if (usersGuess > ranNumber)
            {
                Console.WriteLine("Lower");
               
            }

            else if (usersGuess == ranNumber)
            {

                Console.WriteLine("You guessed the correct number! ");
                
            }
            
        }
    }

    
}