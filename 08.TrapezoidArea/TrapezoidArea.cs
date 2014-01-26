using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Enter a: ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        decimal h = decimal.Parse(Console.ReadLine());
        decimal area = ((a + b) / 2) * h;
        Console.WriteLine("The area of the trapezoid is {0:0.00}",area);
    }
}
