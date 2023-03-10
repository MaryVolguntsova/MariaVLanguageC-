//  Задача 65
// Задайте значения M и N. 
// Напишите программу, которая найдёт все натуральные элементы в промежутке от M до N.
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
string RecMN(int m, int n)
{
    string result = string.Empty;
    if(m>=n){result = n.ToString();}
    else{result = result + m + " " + RecMN(m+1, n); }
    return result.ToString();
}
int one = ReadData("Введите число M: ");
int two = ReadData("Введите число N: ");
string res = one < two?RecMN(one, two):RecMN(two, one);
PrintData(res.ToString());
