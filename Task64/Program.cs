/*Задача 63:** Задайте значение N. Напишите программу,
которая выведет все натуральные числа в
промежутке от 1 до N.

N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

using System;
using static System.Console;
Clear();
// int N=5;
Write("Введите число: ");
int N = int.Parse(ReadLine()!);

string result = GetNumbers(1, N);
WriteLine($"Натуральные числа в промежутке от 1 до введенного вами: {result}");
static string GetNumbers(int start, int end)
{
    if(start==end) return start.ToString();
    return(start+" "+GetNumbers(start+1,end));
}
// Console.WriteLine