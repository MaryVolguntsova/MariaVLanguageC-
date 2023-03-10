// Задача 69 
// Напишите прграмму, которая будет принимать 2 числа А и В
// возыедите А в степень В с помощью рекурсии
int ReadData(string line)
{
    // Выводим сообщение(что хотим получить)
    Console.Write(line);
    // сразу возвращаем значение, не заводя его в переменную 
    return Convert.ToInt32(Console.ReadLine()??"0");
}

long RecPow(int a, int b)
{
    if(b <= 1){return a;}
    else{return a*RecPow(a, b-1);}
}

// long MyPowRec(int a, int b)
// {
//     if (b ==2)
//     {
//         return a*a;
//     }
//     else
//     {
//         return MyPowRec(a,b/2)*MyPowRec(a,b/2);
//     }
// }

int number = ReadData("Введите число: ");
int pow = ReadData("Введите степень: ");
long result = RecPow(number, pow);
Console.WriteLine(result);

