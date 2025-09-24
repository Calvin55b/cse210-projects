using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int userNum = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> nums = new List<int>();

        while (userNum != 0)

        {
            Console.Write("Enter number: ");
            userNum = int.Parse(Console.ReadLine());

            if (userNum != 0)
            {
                nums.Add(userNum);

            }
        }
        int greatest = nums[0];

        foreach (int number in nums)
        {
            if (number > greatest)
            {
                greatest = number;
            }

        }

        int sum = 0;
        foreach (int number in nums)
        {
            sum += number;
        }



        float average = (float)sum / nums.Count();


        Console.WriteLine($"The Sum is: {sum} ");
        Console.WriteLine($"The average is: {average} ");
        Console.WriteLine($"The largest number is: {greatest}");
    }
}