// See https://aka.ms/new-console-template for more information
/*
8. Mer beräkningar
Be användaren mata in en summa. Lägg på 25% moms dvs summan gånger 0,25 och
skriv på skärmen den nya summan med moms.
*/

Console.WriteLine("Skriv in tal 1");
int FirstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Skriv in tal 2");
int SecondNumber = int.Parse(Console.ReadLine());
int Sum = FirstNumber + SecondNumber;
int Difference = FirstNumber - SecondNumber;
Console.WriteLine($"Summa av dina två tal är: {Sum}  \nDifferens mellan dina två tal är: {Difference}");
float Tax =  Sum * 0.25f;
Console.WriteLine($"Skatten på beloppet är =  {Tax}");
Console.WriteLine($"Totalt belopp med skatt är =  {Sum + Tax}");
