//Day 2

using System;
namespace CSharpSelfLearning;

class Program
{
    static void Main(string[] args)
    {
        //Sixth Video Showed
        //Simple Arithmetic

        int friends = 50; //Addition
        int eggs = 50; //Substraction
        int spoons = 50; //Multiplication
        int pigs = 50;  //For Division I can use double instead of integer for 12.5 / .5
        int battery = 50; //Percent

        //Addition
        friends = friends + 1; //Beginner Use
        friends += 1; //Shorcut
        friends++; //Only 1 added

        //Substraction
        eggs = eggs - 1; //Beginner Use
        eggs -= 1; //Shorcut
        eggs--; //Only 1 deduct

        //Multiplication
        spoons = spoons * 1; //Beginner Use
        spoons *= 1; //Shorcut

        //Division
        pigs = pigs / 1; //Beginner Use
        pigs /= 1; //Shorcut

        //Percent
        int percentage = battery % 50; //Percent


        Console.WriteLine(friends); //Total Friends output
        Console.WriteLine(eggs); //Total Eggs output
        Console.WriteLine(spoons); //Total Spoons output
        Console.WriteLine(pigs); //Total Pigs Output
        Console.WriteLine(percentage); //Total Output For Percentage

        Console.ReadKey();
    }
}