using System;

public class EggOrder
{
    public static void Main(string[] args)
    {
        // Prompt user for the number of eggs
        Console.WriteLine("Welcome to Miss Lee's Dairy Farm!");
        Console.Write("Please enter the number of eggs you would like to order: ");
        int numEggs = int.Parse(Console.ReadLine());

        // Calculate the order cost
        double totalCost;
        if (numEggs % 12 == 0)
        {
            int dozenEggs = numEggs / 12;
            totalCost = dozenEggs * 30.50;
        }
        else
        {
            int dozenEggs = numEggs / 12;
            int individualEggs = numEggs % 12;
            totalCost = dozenEggs * 30.50 + individualEggs * 2.50;
        }

        // Display the order details
        Console.WriteLine("\nYour order details:");
        Console.WriteLine($"Number of eggs: {numEggs}");
        Console.WriteLine($"Dozens of eggs: {numEggs / 12}");
        Console.WriteLine($"Individual eggs: {numEggs % 12}");
        Console.WriteLine($"Total cost: R{totalCost:0.00}");

        // Thank the customer
        Console.WriteLine("\nThank you for your order!");
    }
}
