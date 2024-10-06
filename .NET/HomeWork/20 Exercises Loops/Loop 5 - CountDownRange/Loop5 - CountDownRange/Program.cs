/*
 5.LOOP #5

Skapa ett program där användaren får mata in ett tal. Låt sedan programmet skriva ut
alla siffor som är mindre än det inmatade talet men större än 0. Lös detta med en
loop.


 ********************** Solution Via While Loop  **********************
  int i = 0;
Console.WriteLine("Skriv en sifra!");
int userInput = int.Parse(Console.ReadLine());
while (userInput -1 > i)
{
    i++;
    Console.WriteLine(i);
}
 */

Console.WriteLine("Skriv en sifra!");
int userInput = int.Parse(Console.ReadLine());
for (int i = 1; i < userInput; i++)
{
    Console.WriteLine(i);
}
