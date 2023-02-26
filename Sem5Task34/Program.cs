// / Задача №34
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Вводим функции, которые понадобятся в каждой из задач
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

// Решение самой задачи

int PositiveNums(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
    // Если число делится на 2 без остатка, то "щелкаем" счетчик"
    if(arr[i]%2 == 0) count++;
    }
    return count;
}
int[] test1Arr = Gen1DArray(10, 100, 999);
Console.WriteLine("Сгенерированный массив чисел: ");
Print1DArray(test1Arr);
int result = PositiveNums(test1Arr);
Console.WriteLine($"В массиве найдены {result} четных числа.");
Console.WriteLine(" ");

// Сортировка массива пузырьковым методом*

int[] BubbleArray(int[]arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        // Каждый раз, проходя массив до конца с максимальным значением, когда мы ставим его в конец, то нам уже не надо в дальнейшнем
        // его учитывать, тк он стоит на своем месте в самом конце. То есть массив уменьшаем на 1. arr[j] по умолчанию считается максимальным.
        for(int j = 0; j < arr.Length - 1; j++)
        {
            // Берем первое значение максимальным, и если при сравнении с таковым он действительно больше, то он идет дальше, а следующий встает на его место (ближе к началу)
            if(arr[j] > arr[j + 1])
            {
                // Меняем числа местами при помощи переменной
                int buf = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = buf;
            }
        }
    }
    return arr;
}
int[] test2Arr = Gen1DArray(10, 100, 999);
Console.WriteLine("Массив, заполненный случайными числами в заданном диапазоне: ");
Print1DArray(test2Arr);
DateTime d1 = DateTime.Now;
int[] bubbleArr = BubbleArray(test2Arr);
Console.WriteLine("Время выполнения сортировки: "+(DateTime.Now - d1));
Console.WriteLine("Результат после сортировки пузырьком: ");
Print1DArray(bubbleArr);
Console.WriteLine(" ");

// Сортировка методом подсчета 
// В целом я понимаю, что происходит, но не на каждом конкретном этапе, хотелось бы еще пройтись по этому материалу 
int[] CountArray(int[] arr, int max)
{
    // создаем массив счетчиков, равное самому большому числу в массиве + 1 (для 0)
    int[] count = new int [max + 1];
    for (int i = 0; i < arr.Length; i++)
    {
        // увеличиваем счетчик индекса, соответсвующий каждому числу из диапазона, если оно попадается неоднократно
        count[arr[i]]++;
    }
    int index = 0;
    for(int i = 0; i < count.Length; i++)
    {
        for(int j = 0; j < count[i]; j++)
        // Заполняем новый массив из массива счетчиков
        {
            arr[index] = i;
            index++;
        }
    }
    return arr;
}
int[] test3Arr = Gen1DArray(10, 100, 999);
Console.WriteLine("Массив, заполненный случайными числами в заданном диапазоне: ");
Print1DArray(test3Arr);
DateTime d2 = DateTime.Now;
int[] countArray = CountArray(test3Arr, 999);
Console.WriteLine("Время выполнения сортировки: "+(DateTime.Now - d2));
Console.WriteLine("Результат после сортировки методом подсчета: ");
Print1DArray(countArray);
