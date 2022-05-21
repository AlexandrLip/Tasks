/*Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц.

Например, заданы 2 массива:
1 4 7 2     и     1 5 8 5  
5 9 2 3           4 9 4 2
8 4 2 4           7 2 2 6
5 2 6 7           2 3 4 7

Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/

Console.Clear();

Console.WriteLine("Введите количество строк массива");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int n = int.Parse(Console.ReadLine());
double[,] Array = new double[m, n];
Random random = new Random();
Console.WriteLine();

int[,] numbers1 = GetArray(m, n, 0, 9);
int[,] numbers2 = GetArray(m, n, 0, 9);
PrintArray(numbers1);
Console.WriteLine();
PrintArray(numbers2);
Console.WriteLine();
int[,] numbers3 = Mult2Arrays(numbers1, numbers2);
PrintArray(numbers3);


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

int[,] Mult2Arrays(int[,] array1, int[,] array2)
{
    int[,] MultArray = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            MultArray[i, j] = array1[i, j] * array2[i, j];
        }
    }
    return MultArray;
}
