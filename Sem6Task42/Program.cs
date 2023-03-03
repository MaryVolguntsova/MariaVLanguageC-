// Задача №42 Напишите программу, которая будет 
// преобразовывать десятичное число в двоичное.

string DecToBin(int num)
{
    string res = String.Empty;
    while(num>0)
    {
        res = num%2 + res;
        num = num/2;
    }
    return res;
}
int ReadData(string line)
{
    // Выводим сообщение(что хотим получить)
    Console.Write(line);
    // сразу возвращаем значение, не заводя его в переменную 
    return Convert.ToInt32(Console.ReadLine()??"0");
}
int number = ReadData("Введите десятичное число: ");
string result = DecToBin(number);
Console.Write("Двоичное число: "+result);