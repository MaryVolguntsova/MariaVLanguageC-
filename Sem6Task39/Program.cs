// Задача №39 Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

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
void SwapArray(int[] arr)
{
    int bufElem = 0;
    for(int i = 0; i<arr.Length/2; i++)
    {
        bufElem = arr[i];
        arr[1] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = bufElem;
    }
}
int[] SwapNewArray(int [] arr)
{
    int[] outArr = new int[arr.Length];
    for(int i = 0; i<outArr.Length; i++)
    {
        outArr[i] = arr[arr.Length - 1 - i];
    }
    return outArr;
}
int[] testArray = Gen1DArray(15, 10, 100);
Print1DArray(testArray);
// неверное работает!!!
SwapArray(testArray);
Print1DArray(testArray);
Console.WriteLine(" ");

int[] newArray = SwapNewArray(testArray);
Print1DArray(testArray);
Print1DArray(newArray);
