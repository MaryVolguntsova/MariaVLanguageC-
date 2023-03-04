// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// *Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.
int ReadData(string line)
{
    // Выводим сообщение(что хотим получить)
    Console.Write(line);
    // сразу возвращаем значение, не заводя его в переменную 
    return Convert.ToInt32(Console.ReadLine()??"0");
}
void PrintData(string line)
{
    Console.WriteLine(line);
}
int CountNum(int numM)
{
    int res = 0;
    for(int i = 0; i < numM; i++)
    {
        if((ReadData("Введите число: ")) > 0)
        {res++;    
        }
    }
    return res;
}
int nums = ReadData("Сколько чисел вы хотите проверить?: ");
int res = CountNum(nums);
PrintData("Среди введенных чисел больше нуля: "+res);
