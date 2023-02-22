// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()??"0");
}

//Вводим метод возведения в степень через математическую функцию
string LineBuilder(int num, int pow)
{
    // вводим переменную где будет хранится результат метода, можно написать 
    string res = String.Empty;
    // перебираем числа от 1 до введенного и все возводим в куб
    for(int i = 1; i <= num; i++)
    {
        // записываем в строку результата
        res = res + Math.Pow(i, pow) + " ";
    }

    return res;
}
int num = ReadData("Введите число: ");
Console.WriteLine(LineBuilder(num,1));
// Степень обозначается переменной int pow и тут в данных мы указываем ее значение, а num у нас в переменной
Console.WriteLine(LineBuilder(num,3));
