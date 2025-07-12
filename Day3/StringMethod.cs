//Day 3
using System;
namespace CSharpSelfLearning;

class Program
{
    static void Main(string[] args)
    {
        //StringMethod
        //Ninth Video Showed
        String Name = "Diego Burgos"; //String Name
        String Phone = "09-53-53454-5"; //String Replace - to /
        
        
        //For Lower and Upper
        String UpDisplayName = Name.ToUpper(); //To Upper Case Name
        String LowDisplayName = Name.ToLower(); //To Lower Case Name
        
        Console.WriteLine("Upper Case Name " + UpDisplayName + " Lower Case Name " + LowDisplayName); //OutPut of Upper and Lower
        
        //For Replace
        String ReplaceNumber = Phone.Replace("-", "/"); //Replace - to /
        Console.WriteLine(ReplaceNumber); //Replaced Output
        
        //For Insert
        String InsertName = Name.Insert(0, "Mr. "); //Insert Mr. {name} Diego
        Console.Write(InsertName); //Insert Output
        
        //For getting the First Name and the Last Name
        String FirstName = Name.Substring(0,5); //First Name Get
        String LastName = Name.Substring(5,7); //Last Name Get
        
        Console.WriteLine("Hello your First Name is " + FirstName); //First Name Output
        Console.WriteLine("Your Last Name is" + LastName); //Last Name Output
        
        //For Full Name Count Length
        Console.WriteLine("Total Count Name Lenght " + Name.Length); //Total Length 
        
        Console.ReadKey();
    }
}