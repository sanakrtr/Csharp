using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        string name; 
        int age; 

        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
        Console.WriteLine($"How old are you, {name}?");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Your name is {name}");
        Console.WriteLine($"Your age is {age}");
    }
 }
