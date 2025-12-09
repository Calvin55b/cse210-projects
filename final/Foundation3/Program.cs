using System;

class Program
{
    static void Main(string[] args)
    {

        //For the Lecture Event
        DateOnly date1 = new DateOnly(2026, 01,12);
        TimeOnly time1 = new TimeOnly(11,15);
       Address address1 = new Address();

        address1.SetAddi("123 University Ave", "Provo","UT 84604", "USA");

        

        Lectures lecture1 = new Lectures("Cybersecurity in a Post-Quantum World","A lecture discussing the challenges and solutions in securing data against emerging quantum decryption techniques.",address1, date1,time1, "Dr. Amelia Hawthorne", 250);

        lecture1.GetEventType();
        Console.WriteLine("--Short Description--");
        Console.WriteLine();
       Console.WriteLine(lecture1.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine("--Standard Description--");
        Console.WriteLine(lecture1.GetStandardDetails());

        Console.WriteLine();

        lecture1.GetEventSpecific();
        Console.WriteLine("--Full Details--");
       Console.WriteLine(lecture1.GetFullDetails());
       Console.WriteLine();


    //For the Outdoor Event

     //For the Lecture Event
        DateOnly date2 = new DateOnly(2026, 01,25);
        TimeOnly time2 = new TimeOnly(12,45);
       Address address2 = new Address();

        address2.SetAddi("Sunrise Canyon Trailhead 840 Caynyon Ridge Rd", "St. George","UT 84770", "USA");

        

        Outdoor outdoor1 = new Outdoor("Sunrise Canyon Trail Hike","A guided hiking experience through the Sunrise Canyon trail system. Participants will explore unique rock formations, learn about local wildlife, and enjoy panoramic views of the valley during peak morning light.",address2, date2,time2, "Expected Weather: Clear skies, 65-78°F");

        lecture1.GetEventType();
        Console.WriteLine("--Short Description--");
        Console.WriteLine();
       Console.WriteLine(outdoor1.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine("--Standard Description--");
        Console.WriteLine(outdoor1.GetStandardDetails());

        Console.WriteLine();

        lecture1.GetEventSpecific();
        Console.WriteLine("--Full Details--");
       Console.WriteLine(outdoor1.GetFullDetails());
       Console.WriteLine();

       ///////////////////////////
       
       //This is for the Receptions event//

          DateOnly date3 = new DateOnly(2026, 03,21);
        TimeOnly time3 = new TimeOnly(01,45);
       Address address3 = new Address();

        address3.SetAddi("67 Oceanfront Blvd", "San Diego","CA 92101", "USA");

        

        Receptions reception1 = new Receptions("Evening Networking Reception","A relaxed, elegant reception designed to help attendees connect with industry professionals. Enjoy light refreshments, live music, and meaningful conversations in a comfortable social environment.",address3, date3,time3, "RSVP: events@techconnect.com");

        lecture1.GetEventType();
        Console.WriteLine("--Short Description--");
        Console.WriteLine();
       Console.WriteLine(reception1.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine("--Standard Description--");
        Console.WriteLine(reception1.GetStandardDetails());

        Console.WriteLine();

        lecture1.GetEventSpecific();
        Console.WriteLine("--Full Details--");
       Console.WriteLine(reception1.GetFullDetails());
       Console.WriteLine();



    }
}