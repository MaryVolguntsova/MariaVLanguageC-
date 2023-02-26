// / Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// Добавляем стандартные методы генерации и печати рандомного массива 
int[] Gen1DArray(int len, int min, int max)
{
    // Блок корректировки входных данных 
    if(min > max)
    {
        int buf = min;
        min = max;
        max = buf;
    }
    int[] arr = new int[len];
    for(int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}
void Print1DArray(int[]arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");    
    }
    Console.Write(arr[arr.Length-1]);
    Console.WriteLine("]");
}
int SumOddNums (int[] arr)
{
    int sum = 0;
    // просто проходимся по нечетным индексам массива и суммируем значения 
    for(int i = 1; i < arr.Length; i = i + 2)
    {
        sum = sum + arr[i];
    }
     return sum;
}
int[] testArr = Gen1DArray(10, 1, 10);
Print1DArray(testArr);
int sumOdd = SumOddNums(testArr);
Console.WriteLine("Сумма чисел, находящихся на нечетных позициях: "+sumOdd);
Console.WriteLine(" ");

// Решение задачи с выводом всех пар, которые есть в массиве
string PrintPair(int[] arr)
{
    string res = String.Empty;
    // Берем первое число и далее проходимся по массиву, с каждым отдельным числом потом проходим по массиву снова
   for(int i = 0; i < arr.Length; i++)
  {
    // Второй цикл - сравниваем число в памяти с другими присутствующими в массиве 
    for(int j = 1; j < arr.Length; j++)
    {
        // главные условия
        if(arr[i] == arr[j] && i != j)
        {
            Console.Write("Пара - [");
            Console.Write($"{arr[i]}, {arr[j]}]");
            Console.WriteLine($" - с индексами {i}, {j}");
        }
    }
  }
  return res;
}
// Не получилось сделать так, чтобы пары не задваивались. Одни и те же значения используются несколько раз
// Возможно, нужно попробовать сделать через Dictionary
string result = PrintPair(testArr);