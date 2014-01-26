using System;
//10.Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1  false.

class BitIs1
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter position of bit: ");
        int positionOfBit = int.Parse(Console.ReadLine());
        int mask = 0;
        mask = 1 << positionOfBit;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> positionOfBit;
        bool bitIs1 = bit == 1;
        Console.Write("Is the bit at position {0} \"1\"? ", positionOfBit);
        Console.WriteLine(bitIs1);
    }
}