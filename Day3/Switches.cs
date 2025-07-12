//Day 3
using System;
namespace CSharpSelfLearning;

class Program
{
    static void Main(string[] args)
    {
        //Eleven Video Showed
        //Switches = An efficient alternative to many else if statements

        Console.WriteLine("What day is it today?");
        String DAYGIVEN = Console.ReadLine(); //Read Writeline Given
        
        String DAY = DAYGIVEN.ToLower(); //Lower
        
        switch (DAY) //Like if 
        {
            case "monday": //Case is like IF
                Console.WriteLine("Today is Monday!");
                break;
            case "tuesday":
                Console.WriteLine("Today is Tuesday!");
                break;
            case "wednesday":
                Console.WriteLine("Today is Wednesday!");
                break;
            case "thursday":
                Console.WriteLine("Today is Thursday!");
                break;
            case "friday":
                Console.WriteLine("Today is Friday!");
                break;
            case "saturday":
                Console.WriteLine("Today is Saturday!");
                break;
            case "sunday":
                Console.WriteLine("Today is Sunday!");
                break;
            default: //Defualt is also like else
                Console.WriteLine(DAY + " Is not a day!");
                break;
        }
        
        Console.ReadKey();
    }
}