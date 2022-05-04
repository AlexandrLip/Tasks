/*
Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями
y = k1 * x + b1, y = k2 * x + b2;

значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

using static System.Console;
Console.Clear();

Console.Write("Введите значение k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
 
 
var x = (b2 - b1) / (k1 - k2);
var y = k2 * (b2 - b1)/ (k1 - k2) + b2;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");
