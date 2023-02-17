// Домашняя работа

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

bool PalinTest(int num)
{
    bool res = false;
    if((num/10000 == num%10) && ((num/1000)%10 == (num/10)%10))
    {
        res = true;
    }
    return res;
}

int num = ReadData("Введите число: ");

// Кладем в переменную результат теста, тк там всего правда или ложь
bool resultTest = PalinTest(num);
if(resultTest == true)
{
    Console.WriteLine("Данное число является палиндромом");
}
else
{
    Console.WriteLine("Данное число не является палиндромом");
}


// Решение задачи с 19*