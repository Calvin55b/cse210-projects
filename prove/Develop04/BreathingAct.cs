public class Breathing : Activity
{
    public Breathing() : base(
        "Breathing Activity",
        "To help you relax, this activity assists you to breathe. Clear your mind. Focus on breathing.")
    { }


    public void RunBreathing()
    {
        
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
            BreathIn(Duration / 4);
            Console.WriteLine();
            BreathOut(Duration / 4);
            Console.WriteLine();   
        }
    }



    private void BreathIn(int seconds)
    {
        Console.Write("Breathe in... ");
        Countdown(seconds);
        Console.WriteLine();
    }

    private void BreathOut(int seconds)
    {
        Console.Write("Now breathe out... ");
        Countdown(seconds);
        Console.WriteLine();
    }

    private void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
    }
}
