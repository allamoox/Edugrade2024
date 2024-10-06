/* 
7. LOOP #7 (Överkurs)

Rolling the dice

Kasta två tärningar” och visa resultatet enligt skärmdump ända tills man INTE svarar ”y” eller ”yes” på frågan om igen
 suggest name 
*/
Random randomNumber = new Random(2);
Console.WriteLine("Rolling the dices..."); 

while (true)
{

    int diceOne = randomNumber.Next(1,7);
    int diceTwo = randomNumber.Next(1,7);
    Console.WriteLine($"The Values are ... \n {diceOne} \n {diceTwo}");
    Console.WriteLine("Roll the dice again?");
    string exit = Console.ReadLine().ToLower();
    if (exit != "y" && exit != "yes")
    {
        Console.WriteLine("Bye Bye .. Hej Då .. Ciao .. Adios .. مع السلامة .. Auf Wiedersehen .. Au revoir");
        break;
    };
}