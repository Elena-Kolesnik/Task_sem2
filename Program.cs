// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

using static System.Console;
Clear();

string N = (ReadLine()); 
int s = 2;

if (N.Length < 3)
{
  WriteLine("третьей цифры нет"); 
}
else
{
  WriteLine(N[s].ToString());
}
 



