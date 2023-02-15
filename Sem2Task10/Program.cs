﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// // Решение 1. Пробую через if/else 
Console.Write("Введите любое трехзначное число ");
// вызываем целое число из строки-контейнера Ридлайн и сразу проверяем, что оно содержит данные через ??"0"
int num = int.Parse(Console.ReadLine()??"0");

// проверяем на трехзначность. Я еще пробовала методом if ((num / 10 > 0) && (num / 100 == 0)), но он работал на четырехзнач и выше, но не на двухзнач
if ((num > 99) && (num < 1000))
{
    // c помощью деления отсекаем последнюю цифру и остается двухзначное число. Теперь на его месте(разряде) число из середины, нужно оставить только его, поэтому %
      int digit = (num/10)%10;
      Console.WriteLine("Вторая цифра этого числа "+digit);
}
else
{
     Console.WriteLine("Вы ввели не трехзначное число. Пожалуйста, повторите процесс с трехзначным числом");
}

// Решение 2. Пробую через string и arr
Console.Write("Введите любое трехзначное число ");
string num1 = Console.ReadLine()??"0";
Char[] arr = num1.ToCharArray();
// Узнаем длину массива, чтобы сделать проверку на трехзначность
int size = num1.Length;
// Трехзначное число состоит из массива с 3 числами
if(size == 3)
{
    // Выводим сообщение и ссылку на ячейку в массиве 
    Console.WriteLine("Вторая цифра этого числа "+num1[1]);
}
else
{
    Console.Write("Вы ввели не трехзначное число. Пожалуйста, повторите процесс с трехзначным числом");
}
