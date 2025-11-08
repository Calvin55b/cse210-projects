using System.Runtime.CompilerServices;
using System.Threading;

public class Timer


{
    private List<string> _animation = new List<string>() { "|", "/", "-", "\\" };

    public Timer(){ }




    

    //private DateTime _pauseTime;//

    // This is to see how long the activity is
    public void IsExpired(Activity activity)
    {


        for (int i = activity.Duration; i > 0; i--)
        {
            Console.Write(i);

            Thread.Sleep(1000);
            Console.Write("\b \b");

        }










    }
    // This is the timer to show how long until the user can begin a given activity
    public void TimerToBegin() 
    {


        for (int i = 5; i > 0; i--)
        //Console.Write("You may begin in:");
        {
            Console.Write(i);

            Thread.Sleep(1000);
            Console.Write("\b \b");

        }




           
        
        


    }

    public void PauseWithAnimation()
    {


        DateTime startTime = DateTime.Now;


        DateTime endTime = startTime.AddSeconds(4);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = _animation[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= _animation.Count)
            {
                i = 0;

            }



        }
    }    
        
        public void Countdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }




}