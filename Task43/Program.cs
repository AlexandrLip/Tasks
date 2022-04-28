// Напишите программу, которая задаёт
// массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

using System;
using static System.Console;
Console.Clear();

int[] Array = new int[8];
for (int i = 0; i < Array.Length; i++)
{
   Array[i] = new Random().Next(0, 20);
}
WriteLine($"{string.Join(", ", Array[0..5])}");
WriteLine($"{string.Join(", ", Array[5..8])}");