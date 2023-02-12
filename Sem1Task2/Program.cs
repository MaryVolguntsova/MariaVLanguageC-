// Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.
Console.Write("Ведите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
if(numA > numB)
{
    Console.WriteLine("Наибольшее число: "+numA);
}
else
{
    Console.WriteLine("Наибольшее число: "+numB);
}