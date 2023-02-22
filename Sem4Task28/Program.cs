// Задача №28
// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N

using System.Numerics;
int ReadData(string line)
{
    // Выводим сообщение(что хотим получить)
    Console.Write(line);
    // сразу возвращаем значение, не заводя его в переменную 
    return Convert.ToInt32(Console.ReadLine()??"0");
}
void PrintData(string line)
{
    Console.WriteLine(line);
}
BigInteger FactorialCalc(int num)
{
    BigInteger fact = 1;
    for( int i = 2; i <= num; i++)
    {
        fact *= i;
    }
    return fact;
}

int num = ReadData("Введите число: ");
PrintData("Факториал заданного числа: " +FactorialCalc(num));