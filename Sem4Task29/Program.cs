// Напишите программу, которая задаёт массив из N элементов и выводит их на экран. 
// Ввести с клавиатуры длину массива и диапазон значений элементов.
int ReadData(string line)
{
    // Выводим сообщение(что хотим получить)
    Console.Write(line);
    // сразу возвращаем значение, не заводя его в переменную 
    return Convert.ToInt32(Console.ReadLine()??"0");
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
int[] Gen1DArray(int len, int min, int max)
{
    int[] arr = new int[len];
    for(int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

int len = ReadData("Введите количество элементов массива: ");
int min = ReadData("Введите минимальное значение: ");
int max = ReadData("Введите максимальное значение: ");
int [] testArr = Gen1DArray(len, min, max);
Print1DArray(testArr);

// Дополнительно: Написать программу которая из имен через запятую выберет случайное имя и выведет в терминал Игорь, Антон, Сергей -> Антон 
// Подсказка: Для разбора строки использовать метод string.split(). Для выбора случайного имени метод Random.Next(1,<длина массива имен>+1).
