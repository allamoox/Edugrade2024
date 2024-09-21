// See https://aka.ms/new-console-template for more information
/* 
2. LOOP #2
Skapa ett program där användaren får mata in två tal. Låt sedan programmet skriva ut alla
tal som finns mellan dessa två tal på skärmen. Lös detta med en for-loop.
*/

using System.Security.Cryptography;

Console.WriteLine("Please Enter First Number");
int FirstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Please Enter Second Number");
int SecondNumber = int.Parse(Console.ReadLine());

int SmaNum = Math.Min(FirstNumber, SecondNumber);
int BigNum = Math.Max(FirstNumber, SecondNumber);
Console.WriteLine($"\n Nedan är alla tal som finns mellan {SmaNum} och {BigNum} \n"); 
SmaNum = SmaNum+1;
while (SmaNum < BigNum)
{
    Console.WriteLine($"{SmaNum}");
    SmaNum++;
}