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
        
        SelectOperator(Console.ReadLine(), num1, num2);

        Console.WriteLine("Thanks for playing!");
    }

    public static void SelectOperator(string operatorChoice, int num1, int num2)
    {
        switch (operatorChoice)
        {
            case "a":
                Console.WriteLine($"You selected 'add': {num1 + num2}");
                break;
            case "s":
                Console.WriteLine($"You selected 'subtract': {num1 - num2}");
                break;
            case "q":
                Console.WriteLine("'a' = add, 's' = subtract, 'q' = qonfused, please help, anything else = exit.");
                break;
            default:
                Console.WriteLine("No clue what to do here. Sorry!");
                break;
        }
    }

}