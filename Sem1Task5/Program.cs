// Напишите программу, которая на вход принимает одно число N, 
// а на выходе показывает все целые число от -N до N.

Console.Write("Введите любое целое число: ");

string? lineN = Console.ReadLine();
if(lineN != null)
{
    int N = int.Parse(lineN);
    string res = string.Empty;
    int negN = N*(-1);
    while(negN <= N)
    {
        res = res + negN + "  ";
        negN = negN + 1;
    }

Console.WriteLine(res);
}

// negN = negN++ (тоже, что и +1)
