/*Напишите цикл, который принимает на
вход два числа (A и B) и возводит
число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


using System;
Console.Clear();

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите степень в которую необходимо возвести число: ");
int b = int.Parse(Console.ReadLine());

for (int i = 1; i <= 1; i++)
Console.WriteLine($"число {a} в степени {b} = {Math.Pow(a, b)}");
