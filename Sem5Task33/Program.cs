// Задача №33
// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
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

int SearchElem(int[] arr, int elem)
{
    int result = - 1;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == elem)
        {
            result = i; break;
        }
    }
    return result; 
}
int[] testArr = Gen1DArray(12, -9, 9);
Print1DArray(testArr);
Console.Write("Введите искомый элемент: ");
int elem = int.Parse(Console.ReadLine()??"0");
int searchElem = SearchElem(testArr, elem);
if (searchElem > 0)
{
    Console.WriteLine("Искомый эелемент находится в массиве с индексом: "+searchElem);
}
else
{
    Console.WriteLine("Искомый элемент не найден");
}