using System;
//4.Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.


class CheckThirdDigit
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        bool isSeven = ((number / 100)%10 == 7);
        Console.Write("Is the third number 7? ");
        Console.WriteLine(isSeven);
    }
}
