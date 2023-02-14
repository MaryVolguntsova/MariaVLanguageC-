// Эту задачу необходимо переписать!!!

System.Random numSintezator = new System.Random();

// Вариант 1
int rndNumber = numSintezator.Next(10, 100);
Console.WriteLine(rndNumber);
int firstNum = rndNumber/10;
int secondNum = rndNumber%10;

if(firstNum > secondNum)
{
    Console.Write("Первое число больше второго");
}
else
{
     Console.Write(secondNum);
}

//Вариант 2
char[] digits = numSintezator.Next(10, 100).ToString().ToCharArray();
Console.Write(digits);
int firstNumber = ((int)digits[0])-48;
int secondNumber = ((int)digits[1])-48;

int resultNumber = (firstNumber>secondNum)?resultNumber=firstNumber:resultNumber=secondNumber;
Console.Write(resultNumber);
