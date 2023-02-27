// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
int ReadData(string line)
{
    // Выводим сообщение(что хотим получить)
    Console.Write(line);
    // считываем число  и помещаем его в переменную, к которой будем потом обращаться
    int num = int.Parse(Console.ReadLine()??"0");
    // возвращаем значение 
    return num;
}

// Метод вывода результат
void PrintResult(string line)
{
    Console.WriteLine(line);
}

long InVolNum (int num, int pow)
{
    int count = 0;
    long res  = 1;
    while(count < pow)
    {
        res = res*num;
        count++;
    }
return res;
}
int num = ReadData("Введите число, которое хотите возвести в степень: ");
int pow = ReadData("Введите степень: ");
long result = InVolNum(num, pow);
PrintResult("Результат вычислений = "+result);

// Написать калькулятор с операциями +, -, /, * и возведение в степень.