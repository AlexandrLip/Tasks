/*Задача 64: Задайте значения M и N.
Напишите программу, которая выведет
все натуральные числа по убыванию в промежутке от M до N.
M = 1; N = 5. -> "5, 4, 3, 2, 1"
M = 4; N = 8. -> "8, 7, 6, 5, 4"
*/

using System;
using static System.Console;

Clear();
Console.Clear();

WriteLine("Введи числа через пробел:");
int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int m = numbers[0];
int n = numbers[1];
WriteLine(GetNumbers(m, n));

string GetNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start.ToString() + " " + GetNumbers(start - 1, end));
}