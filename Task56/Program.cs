/*Задача 50. Напишите программу, которая на вход принимает позиции элемента
в двумерном массиве, и возвращает значение этого элемента или же указание,
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17->такого числа в массиве нет*/


Console.Clear();
Console.WriteLine("Введите количество строк массива");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int n = int.Parse(Console.ReadLine());
int[,] numbers = GetArray(m, n, 0, 100);
PrintArray(numbers);
Console.WriteLine("Введи порядковый номер числа:");

Console.WriteLine();
int nSearch, orderNumber, i, j;
int[] indexes;
orderNumber = int.Parse(Console.ReadLine());
Console.WriteLine(FindElementInOrder(orderNumber, numbers));

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

string FindElementInOrder(int num, int[,] arr)
{
    int i, j;
    if (num <= 0 || num > arr.Length)
    {
        return "Такого элемента нет.";
    }
    
    else
    {
        i = num / arr.GetLength(1);
        j = num % arr.GetLength(1) - 1;
        return $"Число с порядковым номером {num}: {arr[i, j]}.";
    }
}
