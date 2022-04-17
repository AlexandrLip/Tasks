/*Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.Clear();

Console.WriteLine("Ведите номер дня недели");
int num = int.Parse(Console.ReadLine());

if(num < 6)
{
    Console.WriteLine($"-> нет");
}
else 
    Console.WriteLine($"-> да");