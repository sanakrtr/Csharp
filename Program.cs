using System;
class Program
{
    static void Main()
    {
        double PI = Math.PI;
        double l, s, v;
        double r;

        Console.Write("Enter radius ");
        r = Convert.ToDouble(Console.ReadLine());
        
        l = 2 * PI * r;
        s = PI * r * r;
        v = 4 / 3 * PI * r * r * r;

        Console.WriteLine("Result: ");
        Console.WriteLine("Length of circle with radius {0} = {1:F2} ", r, l);
        Console.WriteLine("Area of circle with radius {0} = {1:F2} ", r, s);
        Console.WriteLine("Volume of circle with radius {0} = {1:F2} ", r, v);

        Console.ReadKey();
    }
}
