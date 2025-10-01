

class Costume
{
    //attributes
    public string outfit = "";

    public string footwear = "";

    public string tools = "";

    public string size = "";

    //behaviors

    public void Display()
    {
        Console.WriteLine($"outfit: {outfit}, size: {size}");
    }
}