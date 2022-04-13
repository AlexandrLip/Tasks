Console.WriteLine($"введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine($"введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number2 < number1)
{
    Console.WriteLine($"a = {number1}; b = {number2} -> max = {number1}, min = {number2}");
}
    else
{
    Console.WriteLine($"a = {number1}; b = {number2} -> max = {number2}, min = {number1}"); 
}