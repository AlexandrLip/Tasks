//using MassInteraction;
/*Задача 47.Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.

//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9*/

Console.WriteLine("Введите количество строк массива");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int n = int.Parse(Console.ReadLine());
double[,] Array = new double[m, n];
Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Array[i, j] = random.Next(-10, 10) + random.NextDouble();
    }
}


for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"{Array[i, j]:f1} ");
    }
    Console.WriteLine();
}
