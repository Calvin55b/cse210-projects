using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction Fractioninitialize = new Fraction();

        //Fractioninitialize.Fraction1();

        //Fractioninitialize.Fraction2(5);

        //Fractioninitialize.Fraction3(4, 5);

        string textFraction =Fractioninitialize.GetFractionString(1, 6);


        double decimalValue =Fractioninitialize.GetDecimalValue(5, 1658);

        Console.WriteLine($"{textFraction}");

        Console.WriteLine($"{decimalValue}");
    
    }
}