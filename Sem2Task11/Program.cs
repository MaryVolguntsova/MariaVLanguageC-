// Задача №11
//Напишиnt программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int num = new Random().Next(100, 1000);
Console.WriteLine(num);

int lastDigit = num%10;
int fistDigit = num/100;
num = fistDigit*10 + lastDigit;
Console.Write(num);