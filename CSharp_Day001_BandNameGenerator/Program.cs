using System;

namespace CSharp_Day001_BandNameGenerator
{
    class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Band Name Generator (v1.0)");

            Console.Write("What city did you grow up in? ");
            string city = Console.ReadLine();

            Console.Write("What is the name of your pet? ");
            string pet = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Your band name is: " + city + " " + pet);
        }
    }
}
