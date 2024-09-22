/*
 7. Tar 3 tal från användaren och sedan visar resultatet av beräkningen
     (tal1 + tal2) * tal3, samt även resultatet av beräkningen tal1*tal3 + tal2*tal3.
 */

Console.WriteLine("Enter First Number");
int firstNum = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Second Number");
int secondtNum = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Third Number");
int thirdtNum = int.Parse(Console.ReadLine());

Console.WriteLine($"First Number + Second Number  * Third Number is {(firstNum + secondtNum) * thirdtNum} The same result as, First Number * Third Number + Second Number * Third Number, which is {(firstNum * thirdtNum) + (secondtNum*thirdtNum)}");