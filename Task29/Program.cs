/*Напишите программу, которая принимает
на вход число N и выдаёт произведение чисел от 1 до N.

4  -> 24
5  -> 120
*/

using System;
Console.Clear();
Console.Write("Введите N: ");

Console.WriteLine(Mult(int.Parse(Console.ReadLine()!)));


int Mult(int number)
{
    int sub=1;
    for(int i=1; i<=number; i++)
    {
        sub = sub*i;
    }
    return sub;
}