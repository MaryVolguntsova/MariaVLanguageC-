// Задача №40 Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Равенство треугольников: любая сторона должна быть меньше или равна сумме других сторон 
// a <= b+c; b <= a+c; c <= a+b; при сторонах a,b,c

// 1) ReadData
// 2) PrintData
// 3) TriangleTest

int ReadData(string line)
{
    // Выводим сообщение(что хотим получить)
    Console.Write(line);
    // сразу возвращаем значение, не заводя его в переменную 
    return Convert.ToInt32(Console.ReadLine()??"0");
}
void PrintData(string line)
{
    Console.WriteLine(line);
}
bool Test(int a, int b, int c)
{
    return (a<=b+c);
}
bool TriangleTest(int a, int b, int c)
{
    bool result = false;
    if((Test(a, b, c))&&(Test(b, a, c))&&(Test(c, a , b)))
    {
        result = true;
    }
return result;
}

// Решение из чата
Console.Write("Введите длины сторон треугольника через пробел: ");
string input = Console.ReadLine();
string[] sides = input.Split();
int a = int.Parse(sides[0]);
int b = int.Parse(sides[1]);
int c = int.Parse(sides[2]);

if (TriangleTest(a, b, c))
{
    Console.WriteLine("Треугольник с такими сторонами может существовать.");
}
else
{
    Console.WriteLine("Треугольник с такими сторонами не может существовать.");
}