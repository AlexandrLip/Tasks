﻿/***Задача 31:** Задайте массив из 12 элементов,
заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.

Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

using System;

Console.Clear();

int[] array = GetArray(12,-9,9);
Console.WriteLine(String.Join("", array));

int[] GetArray(int size, int maxValue, int minValue)
{
    int[] res = new int[size];

    for (int i =0; i < size; i++)
    {
        res[i]=new Random().Next(minValue, maxValue+1);
    }
    return res;
}