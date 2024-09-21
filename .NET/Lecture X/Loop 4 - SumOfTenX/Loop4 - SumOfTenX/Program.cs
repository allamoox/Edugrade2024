/*
 4. LOOP #4

Be användaren mata in ett tal. Spara värdet i en variabel. Upprepa detta 10 gånger. För

varje gång lägg till det inmatade värdet till variabelns värde. När det är klart skriv ut-
Summan av det du matat in är: summan.

 */
int accumulate = 0;
for (int i = 0; i < 10; i++) 
{

    Console.WriteLine("Var snäll och skriva en sifra");
    int userInput = int.Parse(Console.ReadLine());
    accumulate += userInput ;
};
Console.WriteLine(accumulate);