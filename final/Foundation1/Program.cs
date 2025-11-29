using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video();
    

        v1.SetVideoDescription("Ronaldo vs My Unbeatable Goalie Robot", "Mark Rober", 1590);
        v1.AddComment("@_theo_disu", "Most unexpected collab");
        v1.AddComment("@Antony02468", "Practising with his weaker foot");
        v1.AddComment("@odschannel3561", "7:27 'Sigh' ");

        v1.Display();

        Console.WriteLine();

        Video v2 = new Video();
        v2.SetVideoDescription("Wham!-Last Christmans", "WHAM!", 270);

        v2.AddComment("@jaymilly1275", "We're back baby");
        v2.AddComment("@Peryz_roblox", "ITS OFFICIALLY 1 MONTH UNTIL CHRISTMAS");
        v2.AddComment("@nerolink7", "3 more months to Christmas");

        v2.Display();
         Console.WriteLine();

        Video v3 = new Video();
        v3.SetVideoDescription("Josh Groban - Believe", "Josh Groban", 240);
        v3.AddComment("@karenreardon5398", "The Polar Express anyone?");
        v3.AddComment("@jonnychick6969", "Undoubtedly one of the best Christmas songs of all time");
        v3.AddComment("@meganstagg2556", "This is hands down my favorite Christmas song! His voice is so angelic");
         v3.Display();
         Console.WriteLine();

        Video v4 = new Video();
        v4.SetVideoDescription("HAUSER - Christmas Special - Part 1", "HAUSER", 990);

         v4.AddComment("@dianaleombruno7029", "Again tears are falling down my face");
        v4.AddComment("@klaudiatomak9640","A can listen to music all day all for the glory of God");
        v4.AddComment("@sarahunter5568", "beautiful christmas dress");


         v4.Display();
    }
}