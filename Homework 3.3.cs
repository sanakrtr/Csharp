using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[10];

        Console.WriteLine("Enter 10 integer numbers:");

        // read input numbers from user
        for (int i = 0; i < 10; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sumOfFirst5 = 0;
        int productOfLast5 = 1;

        // calculate sum of first 5 elements if they are positive,
        // otherwise calculate product of last 5 elements
        for (int i = 0; i < 5; i++)
        {
            if (numbers[i] > 0)
            {
                sumOfFirst5 += numbers[i];
            }
            else
            {
                productOfLast5 *= numbers[i + 5];
            }
        }

        // print the result
        if (sumOfFirst5 > 0)
        {
            Console.WriteLine("Sum of first 5 positive elements: " + sumOfFirst5);
        }
        else
        {
            Console.WriteLine("Product of last 5 elements: " + productOfLast5);
        }

        Console.ReadLine();
    }
}
