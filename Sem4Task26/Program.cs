// Задача №26
// Напишите программу, которая принимает на вход число, а в результате дает количество цифр в числе.
int ReadData(string line)
{
    // Выводим сообщение(что хотим получить)
    Console.Write(line);
    // считываем число  и помещаем его в переменную, к которой будем потом обращаться
    int num = int.Parse(Console.ReadLine()??"0");
    // возвращаем значение 
    return num;
}
int DigitSum(int num)
{
    int res = 0;
    while(num>0)
    {
        res+=1;
        num = num/10;
    }
    return res;
}
void PrintResult(string line, int num)
{
    Console.WriteLine(line + num);
}

int num = ReadData("Введите число: ");
PrintResult("Количество цифр в числе: ",DigitSum(num));
