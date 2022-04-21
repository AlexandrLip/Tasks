
Console.WriteLine("Ведите первое число");
int numA = int.Parse(Console.ReadLine());

Console.WriteLine("Ведите второе число");
int numB = int.Parse(Console.ReadLine());

//int numC = numA%numB==0;

if(numA%numB ==0)
{
    Console.WriteLine($"Число {numA} кратно числу {numB}");
}
else
{
    Console.WriteLine($"Число {numA} не кратно числу {numB}");
}