// Напишите программу, которая будет показывать все четные числа от 1 до N (введенного числа)

Console.Write("Введите любое число: ");
int N = Convert.ToInt32(Console.ReadLine());
for(int i=2; i <= N; i = i + 2)
{
    Console.Write(i + " ");
}
