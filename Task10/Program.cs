Console.WriteLine($"введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine($"введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine($"введите третье число: ");
int number3 = int.Parse(Console.ReadLine());

int max = number1;

if (number1 > max ) max = number1;
if (number2 > max ) max = number2;
if (number3 > max ) max = number3;

Console.Write("max = ");
Console.WriteLine(max);