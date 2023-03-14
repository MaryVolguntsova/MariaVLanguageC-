// Задача 68
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int ReadData(string line)
{
    // Выводим сообщение(что хотим получить)
    Console.Write(line);
    // сразу возвращаем значение, не заводя его в переменную 
    return Convert.ToInt32(Console.ReadLine()??"0");
}

// описание функции Аккермана найдено в интернете и прописаны все условия ее выполнения
int Ackermann(int m, int n)
{
 if (m == 0)
{
 return n + 1;
}
else if (n == 0)
    {
    return Ackermann(m - 1, 1);
    }
    else
    {
    return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

int one = ReadData("Введите число M: ");
int two = ReadData("Введите число N: ");
// Проверка на дурака
int res = one < two?Ackermann(one, two):Ackermann(two, one);

Console.WriteLine(res);



