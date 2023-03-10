// Задача №53
// Задайте двумерный массив. Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.
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
            Console.ForegroundColor = col[new Random().Next(0, 16)];
            Console.Write(arr[i, j] + "  ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

// 2 0 0 0
// 1 1 1 1 temp 
// 0 2 2 2
// используем замену через переменные
void Change2DArray(int[,] arr)
{
   int temp = 0;
   for(int i = 0; i < arr.GetLength(1); i++)
   { 
    temp = arr[0, i];
    arr[0, i] = arr[arr.GetLength(0)-1, i];
    arr[arr.GetLength(0) - 1, i] = temp;
      
   }
}
int[,] testArr = Gen2DArr(5, 5, 10, 99);
Print2DArr(testArr);
Change2DArray(testArr);
Console.WriteLine("");
Print2DArr(testArr);
