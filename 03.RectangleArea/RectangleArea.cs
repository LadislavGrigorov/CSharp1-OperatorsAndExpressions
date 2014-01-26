using System;
//3.Write an expression that calculates rectangle’s area by given width and height.

class Program
{
    static void Main()
    {
        Console.Write("Enter height: ");
        decimal height = decimal.Parse(Console.ReadLine());
        Console.Write("Enter width: ");
        decimal width = decimal.Parse(Console.ReadLine());
        decimal area = height * width;
        if ((height > 0) && (width > 0))
        {
            Console.WriteLine("The area of the rectangle is {0}", area);
        }
        else
        {
            Console.WriteLine("Invalid height or width. Numbers must be positive");
        }
    }
}
