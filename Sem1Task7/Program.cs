// Напишите программу, которая на вход принимает трехзначное число, а вы выходе показывает его последнюю цифру

Console.Write("Введите любое трехзначное число: ");
string? num = Console.ReadLine();
if(num != null);
{
    int N = int.Parse(num);
    int res = N % 10;
    Console.WriteLine("Последняя цифра этого числа: "+res);
}
