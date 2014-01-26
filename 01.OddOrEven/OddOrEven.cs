using System;
//1.Write an expression that checks if given integer is odd or even.

class OddOrEven
{
    static void Main()
    {
        Console.Write("Eneter number: ");
        int number = int.Parse(Console.ReadLine());
        bool even = (number % 2 == 0);
        Console.Write("Is the nubmer even? ");
        Console.WriteLine(even);
    }
}
