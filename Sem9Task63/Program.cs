// Задача 63
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от N до 1. Выполнить с помощью рекурсии.
int ReadData(string line)
{
    // Выводим сообщение(что хотим получить)
    Console.Write(line);
    // сразу возвращаем значение, не заводя его в переменную 
    return Convert.ToInt32(Console.ReadLine()??"0");
}

void LineGenRec(int num)
{
    Console.Write(num + " ");
    if(num == 1){ }
    else{LineGenRec(num-1);}
}
int number = ReadData("Введите число N: ");
LineGenRec(number);
