using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetTop());
        Console.WriteLine(f1.GetBottom());
        Console.WriteLine(f1.GetFractionstring());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetTop());
        Console.WriteLine(f2.GetBottom());
        Console.WriteLine(f2.GetFractionstring());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetTop());
        Console.WriteLine(f3.GetBottom());
        Console.WriteLine(f3.GetFractionstring());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetTop());
        Console.WriteLine(f4.GetBottom());
        Console.WriteLine(f4.GetFractionstring());
        Console.WriteLine(f4.GetDecimalValue());

        Fraction f5 = new Fraction();
        f5.SetTop(7);
        f5.SetBottom(8);
        Console.WriteLine(f5.GetFractionstring());
        Console.WriteLine(f5.GetDecimalValue());
    }
}