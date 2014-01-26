using System;
//11. Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.
class ValueOfBit
{
    static void Main()
    {
        Console.Write("Write an integer number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter the position of the bit you want: ");
        int position = int.Parse(Console.ReadLine());
        int mask = 0;
        mask = 1 << position;
        int numberAndMask = number & mask;
        int bit = numberAndMask >> position;
        Console.WriteLine("The value of the bit is: {0}", bit);
    }
}
