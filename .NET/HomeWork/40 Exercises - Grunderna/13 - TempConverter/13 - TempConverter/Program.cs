/*13. Ber användaren mata in ett tal som representerar grader i celsius och sedan konverterar 
       värdet till både Fahrenheit och Kevlin. Presentera resultatet i konsolfönstret.
*/
Console.WriteLine("Salam! Please enter a temperature in Celsius. I'll magically convert it to both Fahrenheit and Kelvin in less than a second... Yes, I'm a magician! xD");

float celisusTemprature = float.Parse(Console.ReadLine());
float fahrenheitTemp = (9.0f / 5 * celisusTemprature) + 32;
float kelvinTempreature = celisusTemprature + 273.15f;

Console.WriteLine($"Temperature in Fahrenheit: {fahrenheitTemp}");
Console.WriteLine($"Temperature in Kelvin: {kelvinTempreature}");