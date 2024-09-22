/*
9. Ber användaren mata in två tal som sparas ner i varsin variabel och sedan 
     skriver ut båda talen i konsolfönstret. 
     Sedan ska variablerna byta värde med varandra och sedan skriva ut sina tal 
     till konsolfönstret igen.
*/

Console.WriteLine("Please Enter First Number");
int firstNumber = int.Parse(Console.ReadLine()); 
Console.WriteLine("Please Enter Second Number");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine($"First Number is {firstNumber} & Second Number is {secondNumber}");
int tempVar = firstNumber;
firstNumber = secondNumber;
secondNumber = tempVar;
Console.WriteLine($"First Number is {firstNumber} & Second Number is {secondNumber}");