/*
 8. Ber användaren om tre bokstäver (en i taget)  och sedan skriver ut dessa i    
     omvänd ordning från hur användaren matade in dessa.
*/

Console.WriteLine("You Need To Enter Three Letters, one at a time. Please Enter Your First Letter:");
char firstLetter = Console.ReadLine()[0];
Console.WriteLine("Please Enter Your Second Letter:");
char secondLetter = Console.ReadLine()[0];
Console.WriteLine("Please Enter Your Third Letter:");
char thirdLetter = Console.ReadLine()[0];
Console.WriteLine($"Your Letters Reserved Are {thirdLetter}{secondLetter}{firstLetter}");