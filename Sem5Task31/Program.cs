// Задача №31
// Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
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
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}
(int posit, int negot) NegPosSum(int[] arr)
{
    int positSum = 0;
    int negotSum = 0;
    for(int i = 0; i<arr.Length; i++)
    {
        if(arr[i]>0)
        {
            positSum += arr[i];
        }
        else
        {
            negotSum += arr[i];
        }
        

    }
    return(positSum, negotSum);
}


int[] testArr = Gen1DArray(12, -9, 9);
Print1DArray(testArr);
(int posit, int negot) results = NegPosSum(testArr);
PrintData("Сумма положительных значений в массиве: ", results.posit);
PrintData("Сумма отрицательных значений в массиве: ", results.negot);

// int len = ReadData("Введие количество элементов массива: ");
// int min = ReadData("Введите минимальное значение заполнения массива ");
// int max = ReadData("Введите максимальное значение заполнения массива ");
// Print1DArray(Gen1DArray(len, min, max));
