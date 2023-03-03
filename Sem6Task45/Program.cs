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

int[] CopyArrayStandartTools(int[] arr)
{
    int[] outArr = new int[arr.Length];
    arr.CopyTo(outArr, 0);
    return outArr;
}
int[] testArr = Gen1DArray(40, 1, 50);
Print1DArray(testArr);

int[] testArrNew = CopyArrayStandartTools(testArr);
Print1DArray(testArrNew);
