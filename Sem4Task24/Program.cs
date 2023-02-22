// Задача №24
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// Запрос данных у пользователя
int ReadData(string line)
{
    // Выводим сообщение(что хотим получить)
    Console.Write(line);
    // считываем число  и помещаем его в переменную, к которой будем потом обращаться
    int numberP = int.Parse(Console.ReadLine()??"0");
    // возвращаем значение 
    return numberP;
}

// Метод вывода результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}
// Метод сложения чисел
long SumSimple(int numA)
{
    long sum = 0;
    for(int i = 0; i<=numA; i++)
    {
        sum+=i;
        // sum = sum+1
    }
    return sum;
}

// Алгоритм Гаусса для нахождения суммы от 1 до заданного числа (аналитическое решение задачи)

long SumGausse(int numA)
{
    return ((1 + (long)numA)*(long)numA)/2;
}

int numberA = ReadData("Введите число A: ");
// long для длинных чисел от 65 миллиардов
DateTime d1 = DateTime.Now;
long res1 = SumSimple(numberA);
Console.WriteLine("Время выполнения метода: "+(DateTime.Now - d1));
PrintResult("Сумма чисел от 1 до А (простой метод): "+res1);

DateTime d2 = DateTime.Now;
long res2 = SumGausse(numberA);
Console.WriteLine("Время выполнения метода: "+(DateTime.Now - d2));
PrintResult("Сумма чисел от 1 до А (метод Гауса): "+res2);

