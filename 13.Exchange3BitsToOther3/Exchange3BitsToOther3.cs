using System;
//13. Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
class Exchange3BitsToOther3
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        int mask3 = 1 << 3;
        int mask24 = 1 << 24;
        int numberAndMask3 = number & mask3;
        int bit3 = numberAndMask3 >> 3;
        int numberAndMask24 = number & mask24;
        int bit24 = numberAndMask24>>24;
        if (bit3==1)
        {
            number |= mask24;
        }
        else if (bit3==0)
        {
            number = number & (~mask24);
        }
        if (bit24 == 1)
        {
            number |= mask3;
        }
        else if (bit24 == 0)
        {
            number = number & (~mask3);
        }
        int mask4 = 1 << 4;
        int mask25 = 1 << 25;
        int numberAndMask4 = number & mask4;
        int bit4 = numberAndMask4 >> 4;
        int numberAndMask25 = number & mask25;
        int bit25 = numberAndMask25 >> 25;
        if (bit4 == 1)
        {
            number |= mask25;
        }
        else if (bit4 == 0)
        {
            number = number & (~mask25);
        }
        if (bit25 == 1)
        {
            number |= mask4;
        }
        else if (bit25 == 0)
        {
            number = number & (~mask4);
        }
        int mask5 = 1 << 5;
        int mask26 = 1 << 26;
        int numberAndMask5 = number & mask5;
        int bit5 = numberAndMask5 >> 5;
        int numberAndMask26 = number & mask26;
        int bit26 = numberAndMask26 >> 26;
        if (bit5 == 1)
        {
            number |= mask26;
        }
        else if (bit5 == 0)
        {
            number = number & (~mask26);
        }
        if (bit26 == 1)
        {
            number |= mask5;
        }
        else if (bit26 == 0)
        {
            number = number & (~mask5);
        }
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

    }
}
