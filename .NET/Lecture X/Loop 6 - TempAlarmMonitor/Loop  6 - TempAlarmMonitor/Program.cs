/*
6.LOOP #6

Skriv en loop som matar in värden (temperatur)

Om medelvärdet av sista tre > 25 så skriv ut ”Alarm”

a.	lös detta med hjälp av tre rullande tre variabler  
b.	int senaste, int nästsenaste, int tidigaste
c.	lös med lista istället (alla lagras i lista, räkna på tre sista)

############################### Solution Without List ###############################

int latest =0, secondLatest=0, earliest=0;
while (true)
{
    Console.WriteLine("Skriv Tempratur!");
    int temp = int.Parse(Console.ReadLine());

    earliest = secondLatest;
    secondLatest = latest;
    latest = temp;
    if (earliest != 0)
    {
        int avr = (latest + secondLatest + earliest) / 3;
        Console.WriteLine();
        if (avr >25)
        {
            Console.WriteLine("Alarm!");
            Console.Beep();
            Console.Beep();
            Thread.Sleep(2000);
            Console.Beep();
            Console.Beep();
            Thread.Sleep(2000);
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.Beep();
            Console.WriteLine("Alarm!");

        }
    }

}
*/

List<int> tempratures = new List<int>();
while (true)
{
    Console.WriteLine("Skriv Tempratur!");
    int temp = int.Parse(Console.ReadLine());
    tempratures.Add(temp);

    if (tempratures.Count >=3)
    {
        var lastThree = tempratures.Skip(tempratures.Count - 3).Take(3);
        double avr = lastThree.Average();
        if (avr > 25)
        {
            Console.WriteLine("Alarm!");
        }
    }
}