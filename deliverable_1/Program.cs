//Kyle Solesbee 
//Deliverable 1

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int sodaCurrent = 100;
        int chipCurrent = 40;
        int candyCurrent = 60;
        int sodaRestock = 40;
        int chipRestock = 20;
        int candyRestock = 40;
        int sodaNew = 0;
        int chipNew = 0;
        int candyNew = 0;

        Console.WriteLine("Welcome to the restocking tool.");
        Console.WriteLine("How many sodas have been sold today? " + sodaCurrent + " in stock.");
        string sodaInput = Console.ReadLine();
        int sodaSold = int.Parse(sodaInput);

        if (sodaSold > sodaCurrent)
        {
            Console.WriteLine("The value is too high. Stock not adjusted.");

        }
        else
        {
            sodaNew = sodaCurrent - sodaSold;
            Console.WriteLine("There are " + sodaNew + " sodas left.");
        }


        Console.WriteLine("How many chips have been sold today? " + chipCurrent + " in stock.");
        string chipInput = Console.ReadLine();
        int chipSold = int.Parse(chipInput);

        if (chipSold > chipCurrent)
        {
            Console.WriteLine("The value is too high. Stock not adjusted.");

        }
        else
        {
            chipNew = chipCurrent - chipSold;
            Console.WriteLine("There are " + chipNew + " chips left.");
        }

        Console.WriteLine("How many candy have been sold today? " + candyCurrent + " in stock.");
        string candyInput = Console.ReadLine();
        int candySold = int.Parse(candyInput);

        if (candySold > candyCurrent)
        {
            Console.WriteLine("The value is too high. Stock not adjusted.");

        }
        else
        {
            candyNew = candyCurrent - candySold;
            Console.WriteLine("There are " + candyNew + " candy left.");
        }

        int sodaStock = sodaNew;
        int chipStock = chipNew;
        int candyStock = candyNew;


        Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked.");

        if (sodaStock <= sodaRestock)
        {
            Console.WriteLine("Soda needs to be restocked.");
        }

        if (chipStock <= chipRestock)
        {
            Console.WriteLine("Chips needs to be restocked.");
        }

        if (candyStock <= candyRestock)
        {
            Console.WriteLine("Candy needs to be restocked.");
        }

        Console.WriteLine("Goodbye!");
    }
}