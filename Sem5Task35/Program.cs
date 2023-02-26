// // Задача №35
// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
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
int NumElemInRange(int[] arr, int minValue, int maxValue)
{
    int res = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>minValue && arr[i]<maxValue)
        {
            res++;
        }
    }
return res; 
}

int[] testArr = Gen1DArray(123, 0, 100);
Print1DArray(testArr);
int result = NumElemInRange(testArr, 10, 99);
Console.WriteLine("Количество элементов, находящихся в отрезке [10, 99], равно: " + result);

