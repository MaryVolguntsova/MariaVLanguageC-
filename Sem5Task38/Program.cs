// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] Gen1DArray(int len)
{
    double[] arr = new double[len];
    for(int i = 0; i < len; i++)
    {
        // В методе есть магическое число 10, но его можно заменить на переменную (максимальное значение), в данном конкретном случае я не стала
        // Метод такой, что мы составляем вещественное число путем случайного выбора целого числа с максимальным значением 10(в данном случае)
        // а потом прибавляем к нему случайное число до 1 с двумя(можно задать самостоятельно, числами после запятой)
        arr[i] = new Random().Next(10) + Math.Round(new Random().NextDouble(), 2);
    }
    return arr;
}
void Print1DArray(double[]arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+" | ");    
    }
    Console.Write(arr[arr.Length-1]);
    Console.WriteLine("]");
}
double[] testArr = Gen1DArray(10);
Print1DArray(testArr);

double MinMaxDiff(double[] arr)
{
    double min = arr[0];
    for( int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];
    }
    double max = arr[0];
    for( int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return max - min;
}

double result = MinMaxDiff(testArr);
Console.WriteLine("Разница между максимальным и минимальным значением массива: "+result);



//*Отсортируйте массив методом вставки