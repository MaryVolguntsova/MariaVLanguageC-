// // Задача 64: 
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.
int ReadData(string line)
{
    // Выводим сообщение(что хотим получить)
    Console.Write(line);
    // сразу возвращаем значение, не заводя его в переменную 
    return Convert.ToInt32(Console.ReadLine()??"0");
}

// Добавляем i как начальную точку отсчета. По сути, это решение подходит для любого промежутка
void LineGenRec(int num, int i)
{
    Console.Write(i + " ");
    if(num <= i){ }
    else{LineGenRec(num, i + 1);}
}
int number = ReadData("Введите число N: ");
LineGenRec(number, 1);