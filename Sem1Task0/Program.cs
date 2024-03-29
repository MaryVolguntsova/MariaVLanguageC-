﻿//Напишите программу, которая на вход принимает число и 
// выдает его квадрат (число умноженное на само себя)

//Просим пользовтеля ввести данные
Console.Write("Введите любое число: ");

//Формируем "контейнер памяти" и строку для ввода данных. 
// inputNum  - это переменная, она пишется с маленькой буквы всегда (именно переменная)
// ? - после string(строка) обозначает, что мы пока не проверяем переменную на null (отсуствие содержимого в переменной)
string? inputNum = Console.ReadLine();

// Проверяем содержимое переменной. != - не равно null, т.е. оно не пустое. 
if(inputNum != null)
{
    //int.Parse - превращает строку в целое число, т.е. вызывает его из контейнера памяти
    int number = int.Parse(inputNum);

    //Здесь получается вводим еще переменную Аут и в нее кладем квадрат числа
    int outNum = number*number;
    //Можно оформить как int outNum = (int)Math.Pow(number, 2);, в скобках само чсло и указание степени), (int) - принудительно привести к целому

    //Выводим резульат
    Console.Write("Квадрат введенного числа: ");
    Console.WriteLine(outNum);
    //Две строки можно оформить в одно так: Console.WriteLine("Квадрат введенного числа: "+outNum);
}

//Задачу можно решить простой записью Console.WriteLine("Квадрат числа: "+Math.Pow(int.Parse(inputNum),2));
