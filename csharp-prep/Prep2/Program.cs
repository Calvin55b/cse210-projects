using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is the your grade Percentage? ");

        string usersGrade = Console.ReadLine();

        int percentageGrade = int.Parse(usersGrade);
        string letter;
        if (percentageGrade >= 90)
        {
            letter = "A";
        }
        else if (percentageGrade >= 80)
        {
            letter = "B";
        }
        else if (percentageGrade >= 70)
        {
            letter = "C";
        }
        else if (percentageGrade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine($"Congratulations! You passed the course with a {letter}");
        }
        else
        {
            Console.WriteLine($"You failed the course :( Thats alright you'll do better next time. Your letter grade is {letter}");
        }


    }
}