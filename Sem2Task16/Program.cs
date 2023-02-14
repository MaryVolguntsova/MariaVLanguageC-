// Задача №16
// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

void SqeaTest(int firstNum, int secondNum)
{
    if(firstNum == secondNum*secondNum)
    {
        Console.WriteLine("Второе число является квадратом первого ");
    }
    else
    {
        Console.WriteLine("Первое число не является квадратом второго ");
    }
}
Console.WriteLine("Введите первое число: ");
int firstNumer = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumer = Convert.ToInt32(Console.ReadLine());

SqeaTest(firstNumer,secondNumer);
SqeaTest(secondNumer,firstNumer);