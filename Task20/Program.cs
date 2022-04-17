/*Напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.Clear();

Console.WriteLine("Ведите число");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(num > 99 ? num.ToString()[2] : "третьей цифры нет");
