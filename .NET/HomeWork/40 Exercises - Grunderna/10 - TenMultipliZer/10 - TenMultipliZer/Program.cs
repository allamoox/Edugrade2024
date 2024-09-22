/*
 10. Ber användaren mata in ett tal som sedan ska få sin multiplikationstabell 
       från 0 till 10 utskriven i konsolfönstret.
*/
Console.WriteLine("Please Enter a number");
int userInput = int.Parse(Console.ReadLine());
Console.WriteLine($"Below is the Multiplication table for {userInput} from 0 to 10");
for (int i = 0; i <= 10; i++) 
{
    Console.WriteLine($"{i} * {userInput} = {i * userInput}");
}