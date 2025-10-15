class Fraction
{
    //These are the attribuites//
    private int _top;

    private int _bottom;



    // constructors//

    public void Fraction1()
    {
        _top = 1;

        _bottom = 1;

        Console.WriteLine($"{_top}/ {_bottom}");
    }
    public void Fraction2(int numerator)
    {
        _top = numerator;

        _bottom = 1;

        Console.WriteLine($"{_top}/{_bottom}");
    }

    public void Fraction3(int top, int bottom)
    {
        _top = top;

        _bottom = bottom;

        Console.WriteLine($"{_top}/{_bottom}");
    }

    //Getters Setters//

    public string GetFractionString(int _top, int _bottom)
    {
        string textFraction = $"{_top}/{_bottom}";

        return textFraction;
    }

    public double GetDecimalValue(int _top, int _bottom)
    {
        return (double) _top / (double) _bottom;

    
    }


}