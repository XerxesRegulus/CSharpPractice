// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");
Console.WriteLine("Insert First number:");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Insert Second number:");
int secondNumber = int.Parse(Console.ReadLine());


Console.WriteLine("[A] for Addition");
Console.WriteLine("[S] for Subtraction");
Console.WriteLine("[D] for Division");
Console.WriteLine("[M] for Multiplication");

string operation = Console.ReadLine();

switch (operation.ToLower())
{
    case "a":
        Console.WriteLine(firstNumber + secondNumber);
        break;
    case "s":
        Console.WriteLine(firstNumber - secondNumber);
        break;
    case "d":
        Console.WriteLine(firstNumber / secondNumber);
        break;
    case "m":
        Console.WriteLine(firstNumber * secondNumber);
        break;
    default:
        Console.WriteLine("Invalid Operation");
        break;
}