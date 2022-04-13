using System;
Console.Write("Введите число : ");
int N = int.Parse(Console.ReadLine());
int B = 1;

while (B<=N)
{
    if (B % 2 == 0)
        Console.WriteLine($"{B} ");
        B = B + 1;
}
 