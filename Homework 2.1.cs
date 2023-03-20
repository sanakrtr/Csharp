using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter 1 number ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter 2 number ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter 3 number ");
        double c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine((a > -6) && (a < 6) ? "1 number is in range [-5;5]" : "1 number isn`t in range [-5;5]");
        Console.WriteLine((b > -6) && (b < 6) ? "2 number is in range [-5;5]" : "2 number isn`t in range [-5;5]");
        Console.WriteLine((c > -6) && (c < 6) ? "3 number is in range [-5;5]" : "3 number isn`t in range [-5;5]");

        Console.ReadKey();

    }
}