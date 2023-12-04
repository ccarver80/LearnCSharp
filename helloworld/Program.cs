
using System;
using System.Threading;
class Program
{
    // Show the differnt variable types and Print to console
    static void Types()
    {
        // Varible Types:
        int wholeNum = 4;
        double floatStyleNum = 1.2345423;
        bool trueFalse = true;
        string greeting = "Hi, My name is Chris!";
        char singleLetter = 'a';

        // Print to console 
        Console.WriteLine(wholeNum);
        Console.WriteLine(floatStyleNum);
        Console.WriteLine(greeting);
        Console.WriteLine(trueFalse);
        Console.WriteLine(singleLetter);
    }

    //Using Sleep method to demostrate wait between lines of code
    static void Wait(int waitTime)
    {
        Console.WriteLine("Waiting...");
        Thread.Sleep(waitTime);
        Console.WriteLine("Done");
    }

    // Take in 2 numbers and what you want done, and write total to console 
    static void CalculateNumbers(double num1, double num2, string calculation)
    {
        if (calculation.ToLower() == "add")
        {
            double total = num1 + num2;
            Console.WriteLine(total);
        }
        else if (calculation.ToLower() == "subtract")
        {
            double total = num1 - num2;
            Console.WriteLine(total);
        }
        else if (calculation.ToLower() == "multiply")
        {
            double total = num1 * num2;
            Console.WriteLine(total);
        }
        else if (calculation.ToLower() == "divide")
        {
            double total = num1 / num2;
            Console.WriteLine(total);
        }
        else
        {
            Console.WriteLine("Sorry your calculation method was not reconized");
        }
    }

    // Main block when program runs
    static void Main(string[] args)
    {
        Types();
        Wait(1500);
        CalculateNumbers(4.234, 10.9797, "add");

    }
}