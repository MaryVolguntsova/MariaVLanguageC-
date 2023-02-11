//Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли второе число квадратом первого

Console.Write("Введите первое число: ");
string? numLine1 = Console.ReadLine();
Console.Write("Введите второе число: ");
string? numLine2 = Console.ReadLine();

// Обозначение && - "И" - логическая операция - выполняются оба условия
// Обозначение || - "ИЛИ" - логическое операция - выполняется одон из условий

if(numLine1 != null && numLine2 != null)
{
    int num1 = int.Parse(numLine1);
    int num2 = int.Parse(numLine2);
    if(num1*num1 == num2)
    {
        Console.WriteLine("Да, второе число является квдратом первого");
    }
    else
    {
        Console.WriteLine("Нет, второе число не является квадратом первого"); 
    }
}