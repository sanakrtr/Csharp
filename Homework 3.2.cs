using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a month number: ");
        int month = Convert.ToInt32(Console.ReadLine());

        int daysInMonth;

        switch (month)
        {
            case 2:
                daysInMonth = 28;
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                daysInMonth = 30;
                break;
            default:
                daysInMonth = 31;
                break;
        }

        Console.WriteLine($"There are {daysInMonth} days in month {month}.");
        Console.ReadKey();
    }
}