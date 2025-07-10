//Day 2
using System;

namespace CSharpSelfLearning;

class Program
{
    static void Main(string[] args)
    {
        //Fifth Video Showed
        //USER INPUT

        Console.WriteLine("What is your name?");
        String name = Console.Readline(); //Read The Input and paste it on after writeline

        Console.Writeline("What is your age");
        int age = Convert.ToInt32(Console.Readline());

        Console.Writeline("Hello " + name); //Hello [input name]
        Console.Writeline("You are " + age); //You are [input age]

        Console.ReadKey();
    }
}