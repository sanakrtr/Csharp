using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string str = Console.ReadLine();

        int countA = 0, countO = 0, countI = 0, countE = 0;

        foreach (char c in str.ToLower())
        {
            switch (c)
            {
                case 'a':
                    countA++;
                    break;
                case 'o':
                    countO++;
                    break;
                case 'i':
                    countI++;
                    break;
                case 'e':
                    countE++;
                    break;
            }
        }

        Console.WriteLine("Count of 'a': {0}", countA);
        Console.WriteLine("Count of 'o': {0}", countO);
        Console.WriteLine("Count of 'i': {0}", countI);
        Console.WriteLine("Count of 'e': {0}", countE);
    }
}
