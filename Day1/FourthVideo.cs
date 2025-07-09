//Day 1
using System;
﻿namespace CSharpSelfLearning;

class Program
{
    static void Main(string[] args)
    {
        //Fourth Video Showed
        // type casting = Converting a value to a different data type

        double a = 300.54;
        int b = Convert.ToInt32(a); //Converting Double Numbers To Remove .54 to single Integer

        int c = 500;
        double d = Convert.ToDouble(c) + .54; //Converting 500 to become 500.54 

        int e = 1000;
        String f = Convert.ToString(e); //Converting int to String

        String g = "true";
        bool h = Convert.ToBoolean(g); //Connverting String into Boolean

        String i = "M";
        char j = Convert.ToChar(i); //Converting String to Char Single

        Console.WriteLine(j.GetType()); //Display String to Char and get the Type
        Console.WriteLine(h.GetType()); //Display String to Boolean and get the Type
        Console.WriteLine(f.GetType()); //Display Integer to String and get the Type
        Console.WriteLine(d.GetType()); //Display Integer to Double and get the Type
        Console.WriteLine(b.GetType()); //Display Double to Single Integer and get the Type
        
        Console.ReadKey(); //To Hide OutPut Logging Messages
    }
}