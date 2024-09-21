/*
 4. Beräknar arean av en triangel med mått som användaren matat in.
    area = 0.5 * b * h
    Where b is the length of the base of the triangle, and h is the height
*/
Console.WriteLine("Enter Triangle Height:");
double triangleHeight = double.Parse(Console.ReadLine());

Console.WriteLine("Enter Triangle Breadth:");
double triangleBreadth = double.Parse(Console.ReadLine());

double triangleArea = 0.5 * triangleHeight * triangleBreadth;
Console.WriteLine($"The Triangle Area is {triangleArea}");
