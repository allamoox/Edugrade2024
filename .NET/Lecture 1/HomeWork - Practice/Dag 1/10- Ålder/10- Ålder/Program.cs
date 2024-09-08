// See https://aka.ms/new-console-template for more information
/* 
6. Ålder
Skriv ett program som tar in ett födelse år från användaren.
a.	Ta emot födelseåret och räkna ut personens ålder
b.	Skriv på skärmen- Din ålder är: ålder
c.	Pröva att sätta dagens datum i en variabel och utgå från årtalet i detta datum i din beräkning.
*/
Console.WriteLine("Var är ditt födelse år?"); // Console.WriteLine, ny rad kommer att skapas.
Console.Write("Mitt födelse år är : "); // Console.WriteSkrivas på samma rad.
int BirthYear = int.Parse(Console.ReadLine());
int Age = DateTime.Now.Year - BirthYear;
Console.WriteLine($"Din ålder är: {Age}");