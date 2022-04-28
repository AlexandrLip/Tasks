// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3

// Если N = 3 -> 0 1 1

// Если N = 7 -> 0 1 1 2 3 5 8

using System;
using System.Linq;
Console.Clear();

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите последовательность числа: ");
int count = int.Parse(Console.ReadLine());
int s = 0;

while(a > count)
{
    s = (a-1) + (a - 2);

   count++;
   s=a;
}
Console.WriteLine($"{count} = {s}");

// решение

int a1=int.Parse(Console.ReadLine());
int a2=int.Parse(Console.ReadLine());
int n=int.Parse(Console.ReadLine());
Console.Write($"{a1} {a2}");

for (int i = 0; i < n-2; i++)
{
    int b=a1+a2;
    Console.Write($" {b}");
    a1=a2;
    a2=b;
}

//еще одно решение

int F1 =int.Parse(Console.ReadLine());
int F2 =int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());

GetFibonacci(F1, F2, N);

void GetFibonacci(int F1, int F2, int N)
{
    if (N >= 1)
        Console.Write(F1 + " ");
    if (N >= 2)
        Console.Write(F2 + " ");
    for (int i = 0; i < N - 2; i++)
    {
        F2 += F1;
        F1 = F2 - F1;
        Console.Write(F2 + " ");
    }
}
