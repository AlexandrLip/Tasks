/*Напишите программу, которая принимает
на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

using System;
Console.Clear();

Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine());

for (int i = 1; i <= Number; i++)
Console.WriteLine(Math.Pow(i, 3));
