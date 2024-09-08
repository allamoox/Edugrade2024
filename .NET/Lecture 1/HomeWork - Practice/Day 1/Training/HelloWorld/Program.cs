// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

string name = "Mahmoud";
int a = 8;
int b = 24;
Console.WriteLine($"Hello World!, My name is {name} and I'm practicing C#");
Console.WriteLine($" a +  b = {a + b}");
Console.WriteLine("What is your name?");
string UrName = Console.ReadLine();
Console.WriteLine($"Welcome {UrName}, Please enter a first number");
int FirstNum = int.Parse(Console.ReadLine());
Console.WriteLine($"You entered {FirstNum}, Please enter a second number");
int SecondNum = int.Parse(Console.ReadLine());
Console.WriteLine("Please choose an operator from the following + - * /");
string Op = Console.ReadLine();
if (Op == "+")
    Console.WriteLine($"{FirstNum} + {SecondNum} = {FirstNum + SecondNum}");
else if (Op == "-")
    Console.WriteLine($"{FirstNum} - {SecondNum} = {FirstNum - SecondNum}");
else if (Op == "*")
    Console.WriteLine($"{FirstNum} * {SecondNum} = {FirstNum * SecondNum}");
else if (Op == "/")
    Console.WriteLine($"The result of {FirstNum} / {SecondNum} = {FirstNum * SecondNum}");