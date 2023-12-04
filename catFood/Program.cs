using System;
using System.Threading;

// Cat Food store that takes in a repsonse to how many cans of cat food you want. 
class Program
{
    // Calculates cost based on quanity, Discount added if 50 or mor cans are bought
    static double calculationOfCans(double cans)
    {
        Thread.Sleep(1000);
        double price = 0;
        if (cans >= 50)
        {
            double savings = (cans * 2.00) - (cans * 1.50);
            Console.WriteLine($"AMAZING! You apply for our bulk discount, You are buying {cans} cans of cat food at $1.50 instead of $2.00 per can, saving you ${savings}!!!!");
            price = cans * 1.50;

        }
        else
        {
            double cansNeeded = 50 - cans;
            Console.WriteLine($"A discount applies at 50 cans, you need only need {cansNeeded} more cans to get $0.50 off per can!....");
            Thread.Sleep(1000);
            Console.WriteLine("Would you add more cans to your order? Y/N?");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "n" || answer.ToLower() == "no")
            {
                Console.WriteLine($"Ok, Your buying {cans} at $2.00 a can");
                price = cans * 2.00;
            }
            else if (answer.ToLower() == "y" || answer.ToLower() == "yes")
            {
                Console.WriteLine("How many more cans would you like to add to your order?");
                double moreCans = Convert.ToDouble(Console.ReadLine());
                price = calculationOfCans(cans + moreCans);
            }
            else
            {
                Console.WriteLine("Sorry I didnt understand that... Please try again");
                calculationOfCans(cans);
            }

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