// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] Gen2DArr(int countRow, int countColumn, int min, int max)
{
    // Корректировка входных данных
    if (min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    Random rnd = new Random();
    int[,] arr = new int[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}
void Print2DArr(int[,] arr)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new Random().Next(0,16)];
            Console.Write(arr[i, j] + "\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
void Print1DArray(double[]arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+"; ");    
    }
    Console.Write(arr[arr.Length-1]);
    Console.WriteLine("]");
}
// Создаем массив средних значений столбца 
double[] AverageOfColumns(int[,] arr)
{
    double[] res = new double[arr.GetLength(1)];
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        for(int i = 0; i < arr.GetLength(0); i++) 
        {   
        // Накапливаем сумму элементов определенного столбца, при этом индекс нового массива должен совпадать с индексом от arr (0 столбец, 0 строка в массиве res)  
        res[j] = res[j] + arr[i, j];
        }
        // Находим среднее арифметическое
        res[j] = Math.Round(res[j]/arr.GetLength(0), 5);
    }
    return res;
}
// Задаем массив целых чисел, в этой задаче не принципиально запрашивать у пользователя, так что не будем.
int[,] arr2D= Gen2DArr(5,5,10,99);
// Посмотрим на наш массив (понадобится для проверки)
Print2DArr(arr2D);
// Вызываем массив заничений 
double[] testArr = AverageOfColumns(arr2D);
Console.Write("Средние арифметические значения столбцов: ");
// Выводим массив 
Print1DArray(testArr);

