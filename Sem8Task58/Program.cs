// Задача 58 
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
            Console.Write(arr[i, j] + "\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
int[,] MultiArray (int[,] arr1, int [,] arr2)
{
    int rows1 = arr1.GetLength(0);
    int cols1 = arr1.GetLength(1);
    int rows2 = arr2.GetLength(0);
    int cols2 = arr2.GetLength(1);
    
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols1; j++)
        {
            arr1[i, j] = arr1[i, j]*arr2[i, j];
        }
    }
    return arr1;
}

int[,] firstArr = Gen2DArr(6, 5, 1, 9);
int[,] secondArr = Gen2DArr(6, 5, 1, 9);
Print2DArr(firstArr);
Console.WriteLine(" ");
Print2DArr(secondArr);
Console.WriteLine(" ");
if(firstArr.GetLength(0) == secondArr.GetLength(0) && firstArr.GetLength(1) == secondArr.GetLength(1))
{
int[,] resultArr = MultiArray(firstArr, secondArr);
Print2DArr(resultArr);
}
else
{
    Console.WriteLine("Массивы должны быть пропорциональны друг другу, попробуйте еще раз");
}