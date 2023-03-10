// Задача №61
// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде 
// равнобедренного треугольника
int ReadData(string line)
{
    // Выводим сообщение(что хотим получить)
    Console.Write(line);
    // сразу возвращаем значение, не заводя его в переменную 
    return Convert.ToInt32(Console.ReadLine()??"0");
}

//n!/k!*(n-k)! - вычисление конкретного элемента треугольника

long Factorial(int n)
{
    long res = 1;
    for(int i = 1; i <=n; i++ )
    {
        res = res*i;
    }
    return res;
}
void PrintPaskalTriangle(int nRow)
{
    for(int i = 0; i < nRow; i++)
    {
        for(int k = 0; k <nRow-1; k++)
        {
            Console.Write(" ");
        }

        for(int j = 0; j <= i; j++)
        {
            Console.Write(" ");
            Console.Write(Factorial(i)/Factorial(j)*Factorial(i - j));
        }
        Console.WriteLine("");
    }
}


int countRow = ReadData("Введите количество строк треугольника Паскаля: ");
PrintPaskalTriangle(countRow);



