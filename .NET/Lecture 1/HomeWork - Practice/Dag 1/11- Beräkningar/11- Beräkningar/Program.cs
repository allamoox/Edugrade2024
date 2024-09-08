// See https://aka.ms/new-console-template for more information
/*
 7. Beräkningar
Mata in två tal och returnera medelvärde, summa och differens mellan dessa tal
a.	Skriv in Mata in tal 1: Ta emot i en variabel 
b.	Skriv Mata in tal 2: Ta emot i en variabel
c.	Räkna ut medelvärde, summa och differens mellan dessa två tal
d.	Skriv ut de beräknade värdena på skärmen
*/
Console.WriteLine("Skriv in tal 1");
int FirstNumber =  int.Parse(Console.ReadLine());
Console.WriteLine("Skriv in tal 2");
int SecondNumber = int.Parse(Console.ReadLine());
int Sum = FirstNumber + SecondNumber;
int Difference = FirstNumber - SecondNumber;
Console.WriteLine($"Summa av dina två tal är: {Sum}  \nDifferens mellan din två tal är: {Difference}");
