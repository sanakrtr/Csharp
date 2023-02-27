using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Perimetr of {0} square : {1}", a, a * 4);
        Console.WriteLine("Area of {0} square : {1}", a, a * a);

        Console.ReadKey();
    }
}
