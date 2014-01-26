using System;
//6.Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

class PointInCircle
{
    static void Main()
    {
        int radius = 5;
        Console.Write("Enter x: ");
        decimal x = decimal.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        decimal y = decimal.Parse(Console.ReadLine());
        bool inCircle = (x * x) + (y * y) <= radius * radius;
        if (inCircle)
        {
            Console.WriteLine("Point ({0},{1}) is in the circle", x, y);
        }
        else
        {
            Console.WriteLine("Point ({0},{1}) is outside the circle", x, y);
        }
    }
}
