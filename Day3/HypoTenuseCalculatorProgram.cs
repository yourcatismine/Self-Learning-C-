//Day 3
using System;
namespace CSharpSelfLearning;

class Program
{
    static void Main(string[] args)
    {
       //HypoTenuse Calculator Program
       //Eight Video Showed
       
       Console.WriteLine("Given Number 1"); //Given Number 1
       double A = Convert.ToDouble(Console.ReadLine());

       Console.WriteLine("Given Number 2"); //Given Number 2
       double B = Convert.ToDouble(Console.ReadLine());

       double C = Math.Sqrt((A * A) + (B * B)); //A and A, B and B Multiply

       Console.Beep();
       Console.WriteLine("The HypoTenuse Is " + C); //The Result
       //Console.Read(); X
       Console.ReadKey();
    }
}