using System;
//2.Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

class DivideBy7And5
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        bool divideBy7and5 = (number % 7 == 0) && (number % 5 == 0);
        if (divideBy7and5)
	    {
            Console.WriteLine("The number can be divided (without remainder) by 7 and 5 in the same time.");
	    }
        else
        {
            Console.WriteLine("The number can't be divided(without remainder) by 7 and 5 in same time.");
        }
    }
}
