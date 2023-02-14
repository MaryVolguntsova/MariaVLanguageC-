// Задача №12
// Напишите программу, которая будет принимать на вход два числа и выводить, является ли 
// второе число кратным первому. Если второе число некратно первому, то программа выводит остаток от деления.

Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine()??"0");

if(num2 % num1 == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Не кратно, остаток - "+num2%num1);
}