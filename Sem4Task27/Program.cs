// Задача 27: 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int[] NumtoMass(int num)
{
int x = num;
int[] arrNum = new int[x.ToString().Length];
for (int i = 0; i < arrNum.Length; i++)
{
    arrNum[i] = x%10;   
    x = x/10;
}
Array.Reverse(arrNum);
return arrNum;
}
int SumOfDigits(int[] arrNum)
{
    int res = 0;
    for(int i = 0; i < arrNum.Length; i++)
    {
        res = res + arrNum[i];
    }
    return res;
}

Console.Write("Введите любое число: ");
int num = int.Parse(Console.ReadLine()??"0");
DateTime d2 = DateTime.Now;
int[] digits = NumtoMass(num);
int sumOfnum = SumOfDigits(digits);
Console.WriteLine("Время подсчета через массив: "+(DateTime.Now - d2));
Console.Write("Сумма цифр в числе: "+sumOfnum);


// Сделать оценку времени алгоритма через числа и строки