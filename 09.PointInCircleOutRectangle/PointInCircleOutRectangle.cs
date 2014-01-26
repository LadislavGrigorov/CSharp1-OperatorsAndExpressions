using System;
//9.Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
class PointInCircleOutRectangle
{
    static void Main()
    {
        Console.WriteLine("Is the point (x,y) in the circle?");
        Console.Write("Enter x: ");
        decimal positionX = decimal.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        decimal positionY = decimal.Parse(Console.ReadLine());
        int radius = 3;
        bool isInCircle = (positionX - 1) * (positionX - 1) + (positionY - 1) * (positionY - 1) <= radius * radius;
        bool isOutRectangle = ((positionX>1)&&(positionY>-1))||(positionX <= 1);
        if (isInCircle && isOutRectangle)
	    {
		    Console.WriteLine("Point is in circle and out of rectangle"); 
	    }
        else
	    {
            Console.WriteLine("Point is out the circle or in the rectangle");
	    }
    }
}
