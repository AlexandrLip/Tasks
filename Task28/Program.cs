﻿/*Напишите программу, которая принимает на вход число
и выдаёт количество цифр в числе.

456 -> 3
78 -> 2
89126 -> 5
*/

using System;
Console.Clear();
Console.Write("Введите число ");
int num=int.Parse(Console.ReadLine());
int i = 0;

Console.WriteLine($"Количество цифр введенного числа : {count(num)}");

int count(int num)
{
    int i = 0;
    while (num>0)
    {
    num/=10;
    i++;
    }
    return i;
}