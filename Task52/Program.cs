/*Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива.

[3 7 22 2 78] -> 76
*/

using static System.Console;
Console.Clear();

int[] Array = new int[4];
for (int i = 0; i < Array.Length; i++)
{
   Array[i] = new Random().Next(0, 100);
}

int min = Array[0];
int max = Array[0];
for (int i = 1; i < Array.Length; i++)
{
 if (Array[i] > max)
    {
        max = Array[i];
    }
    if (Array[i] < min)
    {
    min = Array[i];
    }
}
   int Raz = max - min;

WriteLine($"{string.Join(", ", Array[0..4])}");

Console.WriteLine($"Разница максимального и минимального элемента в массиве = {Raz}:");







