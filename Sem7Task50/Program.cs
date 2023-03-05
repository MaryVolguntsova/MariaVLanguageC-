// Задача 50
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// *Заполнить числами Фиббоначи и выделить цветом найденную цифру
int ReadData(string line)
{
    // Выводим сообщение(что хотим получить)
    Console.Write(line);
    // сразу возвращаем значение, не заводя его в переменную 
    return Convert.ToInt32(Console.ReadLine()??"0");
}
double[,] FibNum2DArr(int countRow, int countColumn)
{
    double[,] arr = new double[countRow, countColumn];
    int first = 0;
    int last = 1;
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
    {
        // принудительно обозначаем первые цифры массива  единицами. К сожалению, добавить 0 не удалось
        if(j == 0 && i == 0) arr[0,0] = 1;
        else
        {
        arr[i, j] = first + last;
        (first, last) = (last, first+last);
        }
    
    }
    }
    return arr;
}
void Print2DArr(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            // Формируем красивый вывод
            Console.Write("{0, 10}", arr[i, j]);
        }
        Console.WriteLine();
    }
}
void SearchNum(double[,] arr, int num)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            // Формируем красивый вывод
            if (arr[i, j] == num)
        {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(arr[i,j] + "\t");
        Console.ResetColor();
        }
        else
        {
            Console.Write(arr[i,j] + "\t");
        }
        }
        Console.WriteLine();
    }
}
double[,] testArr = FibNum2DArr(5, 5);
Print2DArr(testArr);
int num = ReadData("Введите искомое число: ");
Console.WriteLine("Если оно присутствует в массиве, мы выделим его красным цветом. В противном случае, такого числа в массиве нет");
SearchNum(testArr, num);