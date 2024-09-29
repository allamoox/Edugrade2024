/*
 Ber användaren mata in två tal som sedan kommer att adderas, subtraheras, 
       multipliceras, divideras, restprodukt uträknad, och presenteras i konsolfönstret.
*/

Console.WriteLine("Please Enter a First Number");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Please Enter a Second Number");
int secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine($"Below is the results of {firstNumber} +,-,* and / by {secondNumber}  /n   {firstNumber} + {secondNumber} = {firstNumber + secondNumber}    {firstNumber} - {secondNumber} = {firstNumber - secondNumber}  {firstNumber} * {secondNumber} = {firstNumber * secondNumber}    {firstNumber} / {secondNumber} = {firstNumber / secondNumber}");