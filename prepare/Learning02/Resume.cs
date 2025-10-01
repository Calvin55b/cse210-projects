public class Resume
{
    public string _personsName;

    public List<Job> _job = new List<Job>();

    public void Display() {
        Console.WriteLine($"Name: {_personsName}");

        Console.WriteLine("Jobs:");

        foreach (Job job in _job)
        {
            job.Display();
        }
    }
    
    
}