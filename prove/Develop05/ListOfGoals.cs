public class ListOfGoals
{



    private List<SimpleGoal> _goal = new List<SimpleGoal>();


    private int _totalPoints;




    public List<SimpleGoal> GetGoals()
    {

        return _goal;


    }


   
    
    public int GetTotalPoints()
    {

        
        return _totalPoints;


    }

    public void AddPoint(int points)
    {
        
        _totalPoints += points;

    }


    public void makeGoal()


    {
        Console.WriteLine(@"The types of Goals are:
                1. Simple Goal
                2. Eternal Goal
                3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");


        string typeOfGoal = Console.ReadLine();

        if (typeOfGoal == "1")
        {
            //BasicGoal


            Console.Write("What is the name of your goal? ");

            string name = Console.ReadLine();


            Console.Write("What is a short description of it? ");

            string description = Console.ReadLine();



            Console.Write("How many points is this project worth? ");

            int userpoints = int.Parse(Console.ReadLine());

            BasicGoal goal = new BasicGoal(name, description, userpoints);

            goal.Points(userpoints);

            _goal.Add(goal);



        }

        else if (typeOfGoal == "2")
        {
            //Eternal Goal//


            Console.Write("What is the name of your goal? ");

            string name = Console.ReadLine();


            Console.Write("What is a short description of it? ");

            string description = Console.ReadLine();



            Console.Write("How many points is this project worth? ");

            int userpoints = int.Parse(Console.ReadLine());

            EternalGoal goal = new EternalGoal(name, description, userpoints);



            _goal.Add(goal);


        }



        else if (typeOfGoal == "3")
        {


            //Checklist Goal

            Console.Write("What is the name of your goal? ");

            string name = Console.ReadLine();


            Console.Write("What is a short description of it? ");

            string description = Console.ReadLine();



            Console.Write("How many points is this project worth? ");

            int userpoints = int.Parse(Console.ReadLine());

            Console.Write("Hom many times does this goal need to be accomplished for a bonus? ");

            int goalOfCompletions = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");

            int bonusPoints = int.Parse(Console.ReadLine());




            ChecklistGoal goal = new ChecklistGoal(name, description, userpoints, goalOfCompletions, bonusPoints);

            goal.Points(userpoints);

            _goal.Add(goal);



        }

        else
        {

            Console.WriteLine("Invalid choice");
        }


    }

    public void LoadGoal(SimpleGoal goal)
    {

        
        _goal.Add(goal);



    }





}



