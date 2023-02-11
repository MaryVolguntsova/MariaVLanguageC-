// Напишите программу, которая по номеру дня недели выдает название

Console.Write("Введите число от однго до 7: ");
string? lineDay = Console.ReadLine();
// Можно включить функцию if(day > 0 && day < 8), тогда же нужно включить else 
if(lineDay != null)
{
    int day = int.Parse(lineDay);
    //string[] dayWeek = new string[7];
    //dayWeek[0] = "понедельник";
    //dayWeek[1] = "вторник";
    //dayWeek[2] = "среда";
    //dayWeek[3] = "четверг";
    //dayWeek[4] = "пятница";
    //dayWeek[5] = "суббота";
    //dayWeek[6] = "воскременье";
    
//-- Можно string[] dayWeek = {понедельник, вторник etc}; - обьявление массима стразу с данными

    //Console.WriteLine("Название дня недели: "+dayWeek[day-1]);
    
// Код от преподавателя для заключения в фигурных скобках после if
    string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(day));
    Console.WriteLine(outDayOfWeek);
}
