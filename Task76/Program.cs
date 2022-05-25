/*Задача 66: Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных
элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using System;
using static System.Console;

Clear();
WriteLine("Введи через пробел два числа для определения суммы натуральных чисел между ними:");
int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();


int m = numbers[0];
int n = numbers[1];
WriteLine(Summ(m, n));

int Summ(int start, int end)
{
    if (start == end) return end;
    return (start + Summ(start + 1, end));
}