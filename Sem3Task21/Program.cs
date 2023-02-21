// // Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

// Метод выводит данные пользователю
void PrintData(string msg, double val)
{
    Console.WriteLine(msg+val);
}

// Метод находит расстояние между точками на плоскости
double CalcLen (int x1, int x2, int y1, int y2, int z1, int z2)
{
    return Math.Sqrt((x1 - x2)*(x1 - x2)+(y1 - y2)*(y1 - y2)+(z1 - z2)*(z1 - z2));
}
// Ипользуем метод РидДата, который совмещает в себе ВрайтЛайн и запрос данных. 
//Помещаем введенные числа в переменные, которые будут использоваться в методе рассчета 
int x1 = ReadData("Введите координату точки x точки A");
int y1 = ReadData("Введите координату точки y точки A");
int z1 = ReadData("Введите координату точки z точки A");
int x2 = ReadData("Введите координату точки x точки B");
int y2 = ReadData("Введите координату точки y точки B");
int z2 = ReadData("Введите координату точки x точки B");

// Т.к. результатом будет не целое число, то мы исп. double. Вызываем результат из метода, который был описан выше
double res = CalcLen(x1, x2, y1, y2, z1, z2);
//Выводим результат при помощи метода 
PrintData("Расстояние между точками A и B - ", res);