﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Это писала абсолютно интуитивно, не знаю на сколько он удачный. Сделала массив, заполнила его и просила достать данные в зависимости от введенного номера по индексу.
Console.Write("Введите номер дня недели и узнайте, выходной ли он: ");
string[] weekOne = {"Будний", "Будний","Будний", "Будний", "Будний", "Выходной", "Выходной"};
int numVvod = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Этот день недели - "+weekOne[numVvod-1]);

// Решение через Dictionary

Console.Write("Ведите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine()??"0");
// Что такое словарь быстро поняла, дальше нужно было его заполнить и вызвать  значение. Пока такой же массив по ощущениям, но не нужно колдовать с индексом
// Теперь инетерсно поработать с циклами foreach и for в чужих словарях 
Dictionary<int, string> weekTwo = new Dictionary <int, string>()
{
  {1, "Это понедельник, будний день"},
  {2, "Это вторник, будний день"},
  {3, "Это среда, будний день"},
  {4, "Это четверг, будний день"},
  {5, "Это пятница, будний день"},
  {6, "Это суббота, выходной день"},
  {7, "Это воскресенье, выходной день"}
};

Console.Write(weekTwo[num]);

// Проверка, ввели ли день недели
// if(weekTwo.ContainsKey(weekTwo))
// {
//   Значение ячейки
// }
// else
// {
//   Это не день недели!
// }
