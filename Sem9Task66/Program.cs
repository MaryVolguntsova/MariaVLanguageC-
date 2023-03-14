// Задача 66: 
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int ReadData(string line)
{
    // Выводим сообщение(что хотим получить)
    Console.Write(line);
    // сразу возвращаем значение, не заводя его в переменную 
    return Convert.ToInt32(Console.ReadLine()??"0");
}
int RecSumDigitMN(int m, int n)
{
    // Вводим точку остановки рекурсии;
    if(m >= n) return m;
    else return m + RecSumDigitMN(m+1, n);
}
int one = ReadData("Введите число M: ");
int two = ReadData("Введите число N: ");
// Проверка на дурака
int res = one < two?RecSumDigitMN(one, two):RecSumDigitMN(two, one);

Console.WriteLine(res);