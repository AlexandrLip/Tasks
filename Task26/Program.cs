/*Напишите программу, которая принимает на вход число (А)
и выдаёт сумму чисел от 1 до А.
7 -> 28

4 -> 10

8 -> 36
*/

using System;
Console.Clear();
Console.Write("Введите А: ");
int A=int.Parse(Console.ReadLine());
Console.WriteLine(Summa(A));


int Summa(int number)
{
    int sum=0;
    for(int i=0; i<=number; i++)
    {
        sum += i;
    }
    return sum;
}

