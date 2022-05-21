/*Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку 
наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();

Console.WriteLine("Введите количество строк массива");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int n = int.Parse(Console.ReadLine());
double[,] Array = new double[m, n];
Random random = new Random();
Console.WriteLine();

int[,] numbers = GetArray(m, n, 0, 9);
PrintArray(numbers);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {GetMin(GetSum(numbers))}.");
Console.WriteLine();

int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[] GetSum(int[,] arr)
{
    int k = 0;
    int[] newArray = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            newArray[k] += arr[i, j];
        }
        k++;
    }
    return newArray;
}

int GetMin(int[] arr)
{
    int minIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < arr[minIndex]) minIndex = i;
    }
    return minIndex + 1;
}