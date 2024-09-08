// See https://aka.ms/new-console-template for more information
/*
5.Inmatning och summa
Skapa en applikation där användaren matar in två tal
a.	 Skriv in Mata in tal 1:
b.Ta emot detta tal i en variabel
c.	Skriv in Mata in tal 2:
d.Ta emot värdet på detta tal
e.	Skriv ut på skärmen - Summan av tal1 och tal 2 är: summan
*/

Console.Write("Skriv in Mata in tal 1: ");
int FirstNumber  = int.Parse(Console.ReadLine());
Console.Write("Skriv in Mata in tal 2: ");
int SecondNumber = int.Parse(Console.ReadLine());
int Sum = FirstNumber + SecondNumber;
Console.WriteLine($"Suman av tal1 och tal2 är: {Sum}");