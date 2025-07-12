//Day 2
using System;
namespace CSharpSelfLearning;

class Program
{
    static void Main(string[] args)
    {
        //Seventh Video Showed
        //Math Class

        double price = 10.5;

        double a = Math.Pow(price, 5); //Math Pow 5x5x5x5x5 = 3125
        double b = Math.Sqrt(price); //Math Sqrt Square Root like if price 4 it should be 2x2 = square root is 2 if 64 = 8x8 = 8
        double c = Math.Abs(price); //It change the number into positive if the number is -5 the output would be positive 5
        double d = Math.Round(price); //If 5.5 below = 5 - 5.4 | if 5.5 above = 6 - 5.6
        double e = Math.Ceiling(price); //It always rounds up even if .1 or .9 | 1.1 or 1.5 = 2.0 / 2
        double f = Math.Floor(price); //It removed the decimal to the number like if the number has this .5 / .1 | 10.5 - 10
        double g = Math.Max(price, 10); //It chooses the high number than small if 10, 5 = 10 if 20, 50 = 50
        double h = Math.Min(price, 10); //It chooses the small number than high if 10, 5 = 5 if 20, 50 = 20

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.WriteLine(f);
        Console.WriteLine(g);
        Console.WriteLine(h);

        Console.ReadKey();
    }
}