// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Заданы уравнения y = k1 * x + b1, y = k2 * x + b2, введите значения b1, k1, b2 и k2 через пробел для поиска точки пересечения прямых: ");
int[] n = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();

if(n.Length<=4)
{
double b1 = n[0];
double k1 = n[1];
double b2 = n[2];
double k2 = n[3];
double x = (b2 - b1)/(k1-k2);
double y = k1*x + b1;
Console.Write($"Координаты точки перечения - ({x},{y})");
}
else Console.WriteLine("Вы ввели слишком много чисел, попробуйте еще раз.");