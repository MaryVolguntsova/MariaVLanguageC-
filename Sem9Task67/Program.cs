// Задача 67
// Принимает на вход число и возвращает сумму числа
int ReadData(string line)
{
    // Выводим сообщение(что хотим получить)
    Console.Write(line);
    // сразу возвращаем значение, не заводя его в переменную 
    return Convert.ToInt32(Console.ReadLine()??"0");
}
Console.Clear();
int SumDigit(int num)
{
     if (num < 1)
    {
        return 0 ;
    }
    else
    {
       return num%10+SumDigit(num/10);
    }
   
}

int num = ReadData("Введите число: ");
int res = SumDigit(num);
Console.WriteLine(res);