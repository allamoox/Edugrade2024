/*Övning:
1. Skapa en string array som heter
    days som innehåller 6 dagar (mån-lör)
    Du har glömt 
    söndag! Prutt!
2. Skapa en ny array 
     som heter temp 
     med korrekt antal 
     strängar och kopierar 
     in allt från original arrayen
3. Lägg till söndag i temp arrayen
4. Tilldela den nya arrayen till original 
     variabeln days
*/
string[] days = new string[6];
days[0] = "Monday";
days[1] = "Tuesday";
days[2] = "Wednesday";
days[3] = "Thursday";
days[4] = "Friday";
days[5] = "Saturday";

string[] temp = new string[7];
temp[0] = "Monday";
temp[1] = "Tuesday";
temp[2] = "Wednesday";
temp[3] = "Thursday";
temp[4] = "Friday";
temp[5] = "Saturday";
temp[6] = "Sunday";
days = temp;
for (int i = 0; i < days.Length; i++) {
    Console.WriteLine(days[i]);

}