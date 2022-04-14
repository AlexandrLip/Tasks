/*Напишите программу, которая принимает на вход два
числа и проверяет, является ли одно число квадратом другого.
*/

Console.Clear();

Console.WriteLine("Ведите первое число");
int numA = int.Parse(Console.ReadLine());

Console.WriteLine("Ведите второе число");
int numB = int.Parse(Console.ReadLine());

string answer=(numB*numB==numA)?$"{numB} является квадратом числа {numA}": (numA*numA==numB)
?$"{numA} является квадратом числа {numB}" : $"не является квадратом";
Console.Write(answer);