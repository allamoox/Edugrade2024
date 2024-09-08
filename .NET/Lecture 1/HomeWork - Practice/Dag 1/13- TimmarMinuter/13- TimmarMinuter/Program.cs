// See https://aka.ms/new-console-template for more information
/*
Skapa ett program där användaren matar in ett antal minuter (minst 60 minuter).
Programmet omvandlar sedan detta till timmar och minuter.
a.	Skriv in ”Mata in antal minuter:”
b.	Ta emot detta tal
c.	Räkna om detta till antal timmar och minuter
d.	 Skriv ut på skärmen- Detta är... timmar och ... minuter
*/

using System.Runtime.CompilerServices;

Console.WriteLine("Skriv in \"Mata in antal minuter:\" ");
int Minut = int.Parse(Console.ReadLine());
int Hour = Minut / 60;
int RestMinut = Minut % 60;
Console.WriteLine($"Detta är {Hour} {(Hour == 1 || Hour == 0 ? "Timma" : "Timmer")} och {RestMinut} {(RestMinut == 0 || RestMinut == 1 ? "Minut" :"Minuter")} !");