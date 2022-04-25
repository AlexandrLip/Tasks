﻿/***Задача 32:** Напишите программу замены элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
using System;

Console.Clear();

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));

for (int i = 0; i < 12; i++)
{
    array[i] = array[i]*-1;
    
}
Console.WriteLine(String.Join(" ", array));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
