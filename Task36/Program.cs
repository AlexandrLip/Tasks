/***Задача 33:** Задайте массив. Напишите программу,
которая определяет, присутствует ли заданное
число в массиве.

4; массив [6, 7, 19, 345, 3] -> нет

3; массив [6, 7, 19, 345, 3] -> да
*/


using System;
using static System.Console;

int[] array = {12, 52, -632, -52, 532, 52, 631, -14};
int num = 576;

WriteLine(FindNum(array, num) ? "yes" : "no");

bool FindNum(int[] array, int num)
{
    foreach (int el in array)
    {
        if (el == num)
        {
            return true;
        }
    }
    return false;
}
