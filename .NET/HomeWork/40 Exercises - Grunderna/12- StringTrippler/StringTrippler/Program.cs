/*
 . Ber användaren mata in en valfri sträng som sedan skriver ut strängen tre gånger efter  
       varandra på två olika rader. 
       Den ena gången utan mellanslag mellan strängarna, den andra helt utan mellanslag 
       mellan.
       a. Skriv en lösning där du använder Console.WriteLine().
       b. Skriv en lösning där du använder $().
*/

Console.WriteLine("Salam, Please enter a string of your a choice!");
string userInput = Console.ReadLine();
Console.WriteLine($"{userInput} {userInput} {userInput}");
Console.WriteLine($"{userInput}{userInput}{userInput}");
