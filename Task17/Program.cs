
/*Напишите программу, которая принимает на вход число и
проверяет, кратно ли оно одновременно 7 и 23.

14  ->  нет
46  ->  нет
161 ->  да*/

using System;

Console.WriteLine("Ведите первое число");
int numA = int.Parse(Console.ReadLine());

int numB = 23;
int numC = 7;


/*if(numA%numB%numC ==0)
{
    Console.WriteLine($"Число {numB} кратно числу {numC}");
}
else
{
    Console.WriteLine($"Число {numC} не кратно числу {numA}");
}*/

string answer=((numA%numC==0)&&(numA%numB==0))?"кратно":"не кратно";
Console.Write(answer);