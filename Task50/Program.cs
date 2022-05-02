/*Задайте массив заполненный случайными положительными
трёхзначными числами. Напишите программу, которая покажет
количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/


using static System.Console;
Console.Clear();

int[] Array = new int[4];
for (int i = 0; i < Array.Length; i++)
{
   Array[i] = new Random().Next(100, 999);
}

int sum = 0;
for(int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 == 0)
        sum ++;
        
    }
WriteLine($"{string.Join(", ", Array[0..4])}");
Console.WriteLine($"Количество четных элементов в массиве: {sum}");

