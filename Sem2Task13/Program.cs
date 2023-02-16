﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите любое число: ");
string num = Console.ReadLine()??"0";
// Создаем массив и узнаем его размер, чтобы работать со всеми числами
char[] arr = num.ToCharArray();
int size = num.Length;
// Проверяем число, чтобы в нем было более 3 цифр, этот метод я тестировала в 10 задаче
if(num.Length >= 3)
{
    Console.WriteLine("Третья цифра заданного числа "+num[2]);
}
else
{
    Console.WriteLine("У заданного числа нет третьей цифры!");
}

// * Сделать вариант для числа длиной до 10 цифр не используя char или string
Console.Write("Введите любое число: ");
int secNum = int.Parse(Console.ReadLine()??"0");
int outNum = 0;
// Проверяем, чтоб в числе было 3 или более цифры
if(secNum >= 100)
{
    // Убираем 1 цифру, пока  в числе не останется 3 цифры 
    while(secNum > 999)
    {
        secNum = secNum/10;
    }
    // Выводим только третью цифру
    outNum = secNum%10;
    Console.WriteLine("Третья цифра заданного числа "+outNum);
}
else
{
    Console.Write("У заданного числа нет третьей цифры!");
}