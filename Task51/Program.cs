﻿/*Задайте одномерный массив, заполненный
случайными числами. Найдите сумму элементов,
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/


using static System.Console;
Console.Clear();

int[] Array = new int[4];
for (int i = 0; i < Array.Length; i++)
{
   Array[i] = new Random().Next(0, 100);
}

int sum = 0;
for(int i = 0; i < Array.Length; i++)
    {
        if (i % 2 == 1)
        sum +=Array[i];
        
    }
WriteLine($"{string.Join(", ", Array[0..4])}");
Console.WriteLine($"Количество четных элементов в массиве: {sum}");

