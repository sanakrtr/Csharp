using System;
class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        Console.WriteLine("Enter dog's name:");
        myDog.name = Console.ReadLine();
        Console.WriteLine("Enter dog's mark:");
        myDog.mark = Console.ReadLine();
        Console.WriteLine("Enter dog's age:");
        myDog.age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Dog information: " + myDog);


    }

    struct Dog
    {
        public string name;
        public string mark;
        public int age;

        public override string ToString()
        {
            return $"Name: {name}, Mark: {mark}, Age: {age}";
        }
    }
}