// Напишите программу, которая ищет наибольшее число из трех

Console.Write("Ведите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите третье число: ");
int numC = Convert.ToInt32(Console.ReadLine());
if(numA > numB)
{
    if(numA > numC)
    {
        Console.Write("Наибольшее число: "+numA);
    }
    else
    {
        Console.Write("Наибольшее число: "+numC);
    }
}
else
{
    if(numB > numC)
    {
        Console.Write("Наибольшее число: "+numB);
    }
    else
    {
        Console.Write("Наибольшее число" +numC);
    }
}
// Тернарный оператор?