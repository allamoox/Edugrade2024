/*
 6. Beräknar medeltalet för 4 tal som användaren matar in.7
*/
Console.WriteLine("Enter First Numer");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Second Numer");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Third Numer");
int ThirdNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Fourth Numer");
int fourthNumber = int.Parse(Console.ReadLine());

double average = (firstNumber + secondNumber + ThirdNumber + fourthNumber) / 4.0;
Console.WriteLine(average);