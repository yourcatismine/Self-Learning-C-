//Day 3
using System;
namespace CSharpSelfLearning;

class Program
{
    static void Main(string[] args)
    {
        //Ten Video Showed
        //If Statements = A basic form of decision making 

        Console.WriteLine("Please enter your Age"); //Type Age
        int age = Convert.ToInt32(Console.ReadLine()); //Converting

        if(age > 100) //If 100 Above
        {
            Console.WriteLine("You are too old to sign up!"); //Output Message if greater than 100 was given
        }
        else if(age > 18) //Else if 18 above
        {
            Console.WriteLine("You are signed up!"); //Output Message if 18 above
        } else if(age < 0) //Else if 0 below
        {
            Console.WriteLine("Invalid Age!"); //Output if 0 below was given
        }
        else //Else 18 below
        {
            Console.WriteLine("Only 18+ can able to sign up!"); //Output if underage 18 below
        }

        Console.WriteLine("What is your Name"); //Type Name
        String NAME = Console.ReadLine(); //Read Type Name

        if (NAME != "") //If No name
        {
            Console.WriteLine("Hello there " + NAME); //If name was 
        } else
        {
            Console.WriteLine("You did not type your name!"); //If name wasn't given

        }
    }
}