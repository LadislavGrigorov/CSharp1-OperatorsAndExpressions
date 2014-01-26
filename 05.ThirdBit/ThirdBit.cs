using System;
//5.Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

class ThirdBit
{
    static void Main()
    {
        Console.WriteLine("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        int mask = 1 << 3;
        int maskAndNumber = number & mask;
        int bit = maskAndNumber >> 3;
        if (bit==1)
        {
            Console.WriteLine("Third bit is 1");
        }
        else
        {
            Console.WriteLine("Third bit is 0");
        }
    }
}
