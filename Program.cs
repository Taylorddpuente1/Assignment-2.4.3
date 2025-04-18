using System;

class Program
{
    static void Main()
    {
        int x, y;
        Console.WriteLine("Input the value for X coordinate: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Input the value for Y coordinate: ");
        y = Convert.ToInt32(Console.ReadLine());


        if(x > 0 && y > 0)
        {
            Console.WriteLine("The coordinate point ({0},{1}) lies in the First quadrant.", x, y);
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("The coordinate point ({0},{1}) lies in the Second quadrant.", x, y);
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("The coordinate point ({0},{1}) lies in the Third quadrant.", x, y);
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("The coordinate point ({0},{1}) lies in the Fourth quadrant.", x, y);
        }
        else if (x == 0 && y == 0)
        {
            Console.WriteLine("The coordinate point ({0},{1}) lies at the Origin.", x, y);
        }
        else if (x == 0)
        {
            Console.WriteLine("The coordinate point ({0},{1}) lies on the Y axis.", x, y);
        }
        else if (y == 0)
        {
            Console.WriteLine("The coordinate point ({0},{1}) lies on the X axis.", x, y);
        }
    }
}