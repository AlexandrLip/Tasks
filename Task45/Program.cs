// Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.

// ❗ **Теорема о неравенстве треугольника:**
// каждая сторона треугольника меньше суммы двух других сторон.


// int A = 3;
// int B = 10;
// int C = 3;



// if ((A+B) > C  && (B+C)>A && (C+A) >B)
// {
//     WriteLine("является треугольником");
// }
// else
// {
//     WriteLine("не является треугольником");
// }


using System;
using System.Linq;
Console.Clear();

Console.WriteLine("Введите стороны треугольника через пробел");
string[] trengle = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int num1 = int.Parse(trengle[0]);
int num2 = int.Parse(trengle[1]);
int num3 = int.Parse(trengle[2]);

Console.WriteLine((num1 < num2 + num3) && (num2 < num1 + num3) && (num3 < num2 + num1)? "Такой треугольник может существовать.": "Такого треугольника быть не может");