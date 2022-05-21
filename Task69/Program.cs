/*Задача 54: Задайте двумерный массив.
Напишите программу, которая упорядочит по
убыванию элементы каждой строки двумерного массива.

Задан массив:   Получается:
1 4 7 2         1 2 4 7
5 9 2 3         2 3 5 9
8 4 2 4         2 4 4 8
*/

Console.Clear();

Console.WriteLine("Введите количество строк массива");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int n = int.Parse(Console.ReadLine());
double[,] Array = new double[m, n];
Random random = new Random();
Console.WriteLine();

int[,] numbers = GetArray(m, n, -10, 50);
PrintArray(numbers);
Console.WriteLine();
SortInStrings(numbers);
PrintArray(numbers);

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

void SortInStrings(int[,] array)
{
    int min, mini, minj;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        mini = i;
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            minj = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
                if (array[i, k] < array[mini, minj]) minj = k;
            min = array[i, j];
            array[i, j] = array[mini, minj];
            array[mini, minj] = min;
        }
    }
}