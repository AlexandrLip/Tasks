/*
Напишите программу, которая принимает на вход пятизначное
число и проверяет, является ли оно палиндромом.

*/

Console.Clear();

Console.WriteLine("Ведите пятизначное число");
int num = int.Parse(Console.ReadLine());

int a = num / 10000;
int b = num % 10000 / 1000;
int c = num % 1000 / 100;
int d = num % 100 / 10;
int e = num % 10;

if (a == e && b == d)
    {
    Console.WriteLine("Введенное число палиндром");
    }
    else
    {
    Console.WriteLine("Введенное число не является палиндромом");
    }
    