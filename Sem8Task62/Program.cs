// Задача 62
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Метод заполнения по спирали, можно с любым кол вом столбцов и строк, задаете вручную внизу, или можно у пользователя запросить, я не стала
int[,] SpiralArray (int countRow, int countColumn)
{
int [,] array = new int[countRow, countColumn];
int value = 1;
int x = 0, y = 0, dx = 0, dy = 1;

for (int i = 0; i < countRow*countColumn; i++)
{
    array[x, y] = value++;
    if (x + dx < 0 || x + dx >= countRow || y + dy < 0 || y + dy >= countColumn || array[x + dx, y + dy] != 0)
    {
        int temp = dx;
        dx = dy;
        dy = -temp;
    }
    x += dx;
    y += dy;
}
return array;
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
            Console.Write(arr[i, j].ToString("D2") + " ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
// Для красивого вывода в самом методе Принт были внесены изменения, т.е. формат чисел переведен заранее в двухзначные, чтобы вывод был ровным, его надо менять в зависимости от заданного массива
int[,] testArr = SpiralArray(4 , 4);
Print2DArr(testArr);