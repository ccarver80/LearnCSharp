using System;
using System.Threading;

// Cat Food store that takes in a repsonse to how many cans of cat food you want. 
class Program
{
    // Calculates cost based on quanity, Discount added if 50 or mor cans are bought
    static double calculationOfCans(double cans)
    {
        double price;
        if (cans >= 50)
        {
            price = cans * 1.50;
        }
        else
        {
            price = cans * 2.00;
        }
        return price;
    }

    // Takes in a question, converts answer to a double for math purposes, and sends to calculate how much cans would cost
    static double Ask(string question)
    {
        Console.WriteLine(question);
        double answer = Convert.ToDouble(Console.ReadLine());
        double price = calculationOfCans(answer);
        return price;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Crazy Cat Food Store!");
        double price = Ask("How many cans of cat food do you want?");
        Console.WriteLine("Calculating...");
        Thread.Sleep(2000);
        Console.WriteLine($"Your total is ${price}");
    }
}