//Day 2

using System;
namespace CSharpSelfLearning;

class Program
{
    static void Main(string[] args)
    {
        //RandomNumbers

        Random random = new Random(); //Random Number

        int a = 1;
        int b = 50;
        
        int number = random.Next(a, b); //Randomized Numbers 1 to 50
        double doublenumber = random.NextDouble(); //Random Double Numbers
        
        Console.WriteLine(number);
        Console.WriteLine(doublenumber);
        
        Console.ReadKey();
    }
}