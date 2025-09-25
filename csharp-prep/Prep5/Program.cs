using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

       string nameInput =PromptUserName();

        int numInput = PromtUserNumber();

       int yearInput = PromtUserBirthYear();

        int CalcOnNumber = SquareNumber();

        DisplayResult(nameInput, CalcOnNumber, numInput, yearInput);



        

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcom to the program! ");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromtUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int num = int.Parse(Console.ReadLine());

            return num;

        }
        static int PromtUserBirthYear()
        {
            Console.Write("Please enter the year you were born: ");
            int year = int.Parse(Console.ReadLine());
            int years_old = 2025 - year;
            return years_old;
        }

        static int SquareNumber()
        {
            Console.Write("What integer would you like to square? ");
            int integer = int.Parse(Console.ReadLine());

            int integerSquared = integer * integer;

            return integerSquared;

        }

        static void DisplayResult(string name, int square, int favoriteNum , int birthday)
        {
            Console.WriteLine($"{name}, the square of your number is {square} ");
            Console.WriteLine($"{favoriteNum} is your favorite number! ");
            Console.WriteLine($"{name}, you will turn {birthday}. ");
        }
        
    }
}