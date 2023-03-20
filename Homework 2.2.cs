using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter 1 number ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 2 number ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 3 number ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine((a > b) && (a > c) ? "1 number is max": (b > c) ? "2 number is max" : "3 number is max");
        Console.WriteLine((a < b) && (a < c) ? "1 number is min" : (b < c) ? "2 number is min" : "3 number is min");

        Console.ReadKey();

    }
}
