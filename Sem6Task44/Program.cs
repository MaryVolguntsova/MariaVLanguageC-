// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
int ReadData(string line)
{
    // Выводим сообщение(что хотим получить)
    Console.Write(line);
    // сразу возвращаем значение, не заводя его в переменную 
    return Convert.ToInt32(Console.ReadLine()??"0");
}
string FibNum(int num)
{
    string res = "0 1";
    int first = 0;
    int last = 1;
    for(int i = 2; i < num; i++)
    {
        res = res + (first + last).ToString() + " ";
        (first, last) = (last, first+last);
    }
    return res;
}
int num = ReadData("Enter a number of Fibonacci elements: ");
Console.WriteLine(FibNum(num));



