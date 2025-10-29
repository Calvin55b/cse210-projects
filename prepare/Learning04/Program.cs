using System;

public class Program1
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("John", "Wayne");

        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment("Rodrigo Calsario", "Multiplication", "Section 7.5", "Problems 15-19");

        Console.WriteLine(mathAssignment1.GetSummary());

        Console.WriteLine(mathAssignment1.GetHomeworkList());


        WritingAssignment writingAssignment1 = new WritingAssignment("Juan", "Idaho History", "The death of Napoleon Dynamite");


        Console.WriteLine(writingAssignment1.GetSummary());


        Console.WriteLine(writingAssignment1.GetWritingInformation());





        

        

       

    }
}