/*Напишите программу, которая принимает на вход
координаты двух точек и находит расстояние между
ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

using System;
Console.Clear();

Console.Write("Введите координаты точки А в формате (x, y, z): ");
string[] r = Console.ReadLine().Split(",");
Console.Write("Введите координаты точки В в формате (x, y, z): ");
string[] t = Console.ReadLine().Split(",");
int[] a = new int[3];
int[] b = new int[3];

int result = 0;
for (int i = 0; i < 3; i++)
{
    a[i] = int.Parse(r[i]);
    b[i] = int.Parse(t[i]);
}

for (int i = 0; i < a.Length; i++)
{
    result += (b[i] - a[i]) * (b[i] - a[i]);
}
Console.WriteLine($"Расстояние  = {Math.Sqrt(result):f2}");

