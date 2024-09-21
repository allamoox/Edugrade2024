// See https://aka.ms/new-console-template for more information
/*
 3. LOOP #3
Skapa ett program där användaren
a.	Får mata in två tal.
b.	Skriv sedan till skärmen summan av de två talen.
c.	Skriv sedan en fråga- Vill du fortsätta (J/N)?
d.	Svarar användaren J återupprepas punkt a-c
e.	Svarar användaren N avbryts programmet
 */
while (true)
{
    Console.WriteLine("Skriv din forsta nummer");
    int FirstNumber = int.Parse(Console.ReadLine());
    Console.WriteLine("Skriv din andra nummer");
    int SecondNumber = int.Parse(Console.ReadLine());
    int Sum = FirstNumber + SecondNumber;
    Console.WriteLine($"Summan av {FirstNumber} och {SecondNumber} är {Sum}");
    Console.WriteLine("Vill du förtsätta (J/N)");
    string UserAnswer = Console.ReadLine();
    if (UserAnswer != "J" && UserAnswer !="j") 
    {
        break;
    }
  
}
