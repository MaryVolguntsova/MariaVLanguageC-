// Задача 47
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// *При выводе матрицы показывать каждую цифру разного цвета(цветов всего 16)

// Тк на семинарах мы уже писали метод создания двумерного массива, была необходимость только заменить тип с int на double и ввести
// соотвествующую функцию заполнения через Next Random.
double[,] Gen2DArr(int countRow, int countColumn)
{   
    Random rnd = new Random();
    double[,] arr = new double[countRow, countColumn];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            arr[i, j] = rnd.Next(10) + Math.Round(new Random().NextDouble(), 2);
        }
    }
    return arr;
}
void Print2DArr(double[,] arr)
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
            Console.Write(arr[i, j] + "         ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
int m = ReadData("Введите число строк матрицы: ");
int n = ReadData("Введите число столбцов матрицы: ");
double[,] testArr = Gen2DArr(m,n);
Print2DArr(testArr);