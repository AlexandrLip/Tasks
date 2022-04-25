/***Задача 37:** Найдите произведение пар чисел
в одномерном массиве. Парой считаем первый и
последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

using System;
using static System.Console;

int[] Array = {1, 3, 4, 7, 8, 3, 3};

Multi(Array);
void Multi(int[] Array)
{
    int mult = 1;
    for (int index = 0; index < Array.Length / 2; index++)
    {
        mult = Array[index] * Array[Array.Length - index - 1];
        WriteLine(mult);
    }
if(Array.Length % 2 == 1) WriteLine(Array[Array.Length / 2]);
}