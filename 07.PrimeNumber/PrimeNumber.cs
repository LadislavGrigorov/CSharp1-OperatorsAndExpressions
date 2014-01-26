using System;
//7.Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
class PrimeNumber
{
    static void Main()
    {
        Console.Write("Write an integer number: ");
        int number = int.Parse(Console.ReadLine());
        if (((number%3!=0)&&(number%5!=0)&&(number%7!=0))||((number==3)||(number==5)||(number==7)))
        {
            Console.WriteLine("Number is prime");
        }
        else
        {
            Console.WriteLine("Number is not prime");
        }
    }
}
