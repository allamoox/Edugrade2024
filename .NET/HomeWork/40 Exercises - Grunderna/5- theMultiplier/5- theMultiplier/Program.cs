/*
 5. Tar TRE nummer från användare, multiplicerar dessa och sedan skriver hela 
     formeln. Ex ”1 x 2 x 3 = 6”
*/
Console.WriteLine("Enter First Number");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Second Number");
int secondtNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Third Number");
int thirdNumber = int.Parse(Console.ReadLine());
var sum = firstNumber * secondtNumber * thirdNumber;
Console.WriteLine(sum);