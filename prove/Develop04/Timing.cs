using System.Runtime.CompilerServices;
using System.Threading;

public class Timer


{
    private List<string> _animation = new List<string>() { "|", "/", "-", "\\" };

    public Timer(){ }

   
    


    //private DateTime _pauseTime;//


    public void IsExpired(Activity activity) 
    {


        for (int i = activity.Duration; i > 0; i--)
        {
            Console.Write(i);

            Thread.Sleep(1000);
            Console.Write("\b \b");

        }



        Console.WriteLine("Well Done !!!");

           
        
        


    }

    public void PauseWithAnimation()
    {
        Console.WriteLine("Getting ready....");

         DateTime startTime = DateTime.Now;


        DateTime endTime = startTime.AddSeconds(8);

        int i = 0;

        while(DateTime.Now < endTime)
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






}