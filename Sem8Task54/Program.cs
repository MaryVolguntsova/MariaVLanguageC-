// Задача 54
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
int[] BubbleArray(int[]row)
{
    for(int i = 0; i < row.Length; i++)
    {
        for(int j = 0; j < row.Length - 1; j++)
        {
            if(row[j] > row[j + 1])
            {
                int buf = row[j];
                row[j] = row[j+1];
                row[j+1] = buf;
            }
        }
    }
    return row;
}
void Sort2DArr (int [,] arr)
{
    int[] row = new int [arr.GetLength(1)];
    for(int i = 0; i < row.Length; i++)
    {
        for( int j = 0; j < row.Length; j++)
        {
            row[j] = arr [i, j];
        }
    BubbleArray(row);
    Array.Reverse(row);
    for( int j = 0; j < row.Length; j++)
    {
        arr[i, j] = row[j];
    }
    }
}

int[,] testArr = Gen2DArr(5 , 5, 10, 99);
Print2DArr(testArr);
Console.WriteLine(" ");
Sort2DArr(testArr);
Print2DArr(testArr);




