using System;

class Program
{
    static void Main(string[] args)
    {
        //This is for the initialization and addition of the cycling activity to the list of activities
        ActivityList list = new ActivityList();
        DateOnly date1 = new DateOnly(2025, 03, 05);
        
        Cycling cycling = new Cycling(date1,"Cycling", 25, 4.8);

        
        list.AddActivity(cycling);

        //Creation of the running activity/ addition to the list of activities



         DateOnly date2 = new DateOnly(2025, 08, 15);
        
        Running running = new Running(date2,"Running", 45, 10.0);

       

        list.AddActivity(running);

        //This is the initialization and addition of the swimming activity to the list of activities

         DateOnly date3 = new DateOnly(2026, 09, 06);
        
        Swim swim = new Swim(date3,"Swimming", 60, 35);

        swim.GetLapDistance();

       

        list.AddActivity(swim);


        list.DisplayAll();
        
        
    }
}