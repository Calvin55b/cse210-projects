using System;

class Program
{
    static void Main(string[] args)
    {
        //this initializes the title,desc, of the breathing activity.
        
        Breathing breathing = new Breathing();

        breathing.RunBegin();



        Timer timer = new Timer();
        timer.IsExpired(breathing);


        //this runs the animation for getting ready
        /* Timer timer = new Timer();

         timer.PauseWithAnimation();

         */



    


    }
}