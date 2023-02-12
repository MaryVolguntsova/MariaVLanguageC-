// Напишите программу, которая проверяет, является ли введенное число четным
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num %2 == 0)
{
    Console.Write("Число является четным!");
}
else
{
    Console.Write("Число нечетное.");
}

