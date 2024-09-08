// See https://aka.ms/new-console-template for more information
/*
 4. För och efternamn
Skapa en applikation där användaren matar in för och efternamn.
a.	Skriv ut Skriv in ditt förnamn: Ta emot värdet i en variabel
b.	Låt markören vänta på din inmatning på samma rad.
c.	Gör på samma sätt med efternamnet.
d.	Skriv sedan ut namnen i omvänd ordning.
e.	Se till att resultatet ser ut så här.
  __________________________________________________
 |filе:///C:/users/administrator/documents... - ■ X|
 |-------------------------------------------------|
 | Skriv in ditt förnamn: Eva                      |
 | Skriv in ditt efternamn: Holmlund               |
 | Du heter: Holmlund, Eva                         |
 |_________________________________________________|

*/

Console.Write("Skriv in ditt förnamn: "); string FirstName = Console.ReadLine();
Console.Write("Skriv in ditt efternamn: ");
string LastName = Console.ReadLine();
Console.WriteLine($"Du heter: {LastName}, {FirstName}");