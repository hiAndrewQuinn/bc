// See https://aka.ms/new-console-template for more information

using System;
using System.IO;

class BC
{
    public static void Main()
    {
        Console.WriteLine("bc clone");
        Console.WriteLine("Input number 1:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Now input number 2:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Add or subtract? [asq]");

        switch (Console.ReadLine())
        {
            case "a":
                Console.WriteLine($"You selected 'add': {num1 + num2}");
                break;
            default:
                Console.WriteLine("No clue what to do here. Sorry!");
                break;
        }
        Console.WriteLine("Thanks for playing!");
    }
}