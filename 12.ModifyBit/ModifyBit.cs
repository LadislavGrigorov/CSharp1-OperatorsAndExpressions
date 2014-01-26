using System;
//12.We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
//    Example: n = 5 (00000101), p=3, v=1  13 (00001101)
//    n = 5 (00000101), p=2, v=0  1 (00000001)

class ModifyBit
{
    static void Main()
    {
        Console.Write("Write an integer number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Value of bit(0/1): ");
        int valueOfBit = int.Parse(Console.ReadLine());
        Console.Write("Enter position of bit: ");
        int position = int.Parse(Console.ReadLine());
        int mask = 0;
        mask = 1 << position;
        int newNumber = 0;
        if (valueOfBit==1)
        {
            newNumber = number | mask;
        }
        else
        {
            newNumber = number & (~mask);
        }
        Console.WriteLine(newNumber);
        string numberInBits = Convert.ToString(number,2).PadLeft(32,'0');
        Console.WriteLine("{0} - input number", numberInBits);
        string newNumberInBits = Convert.ToString(newNumber, 2).PadLeft(32,'0');
        Console.WriteLine("{0} - number with changed bit", newNumberInBits);

    }
}
