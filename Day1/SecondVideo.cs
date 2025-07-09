//Day 1
using System;
﻿namespace CSharpSelfLearning;

class Program
{
    static void Main(string[] args)
    {
        //Second Video Showed
        int x; //Declaration
        x = 200; //Initialization

        int y = 500; //Declaration and Initialization
        int z = x + y; //Simple Calculation PLus

        int Age = 17;
        double Height = 21.3; //For Douvble Numbers Like 1.21 or 54.1
        bool IsAlive = true; //Boolean Values True or False
        char MiddleName = 'C'; //Single Character
        string Name = "Diego Burgos"; //String Texts

        Console.WriteLine("Hello " + Name);
        Console.WriteLine("Your Age is " + Age + " Height " + Height);
        Console.WriteLine("IsAlive? " + IsAlive);
        Console.WriteLine("Middle Name" + MiddleName);
        Console.WriteLine(x); //Display X Integer
        Console.WriteLine(y); //Display Y Integer
        Console.WriteLine(z); //Display Z - X + Y or Y + X

        Console.ReadyKey(); //To Hide OutPut Logging Messages
    }
}