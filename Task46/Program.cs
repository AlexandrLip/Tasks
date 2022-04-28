// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10

using System;
using System.Linq;
Console.Clear();

//метод №1:
/*
Console.Write("Enter number: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Convert.ToString(i,2));
*/

/*
Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());
string result =" ";

while (num > 0)
{
    result = (num % 2).ToString() + result;
    num/=2;
}
//result = (num / 2).ToString() + result;
Console.WriteLine(result);
*/

// int N = int.Parse(ReadLine());
// string s = string.Empty;
// while(N>0)
// {
//     s = N%2+s;
//     N = N/2;
// }


// новое решение от учителя:
// using System;
// Console.WriteLine(DecToNum(10,16));



// string DecToNum(int decNumber, int otherSystem)
// {
//     string res="";
//     string nums="0123456789ABCDEF";
//     while(decNumber>0)
//     {
//         int ost=decNumber/otherSystem;
//         res=nums[decNumber-otherSystem*ost]+res;
//         decNumber/=otherSystem;
//     }
//     return res;
// }


Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Enter систему исчисления: ");
int basic = int.Parse(Console.ReadLine());
string result =" ";

int convertNumber(int number, int found);
while (num > 0)
{
    result = (num % 2).ToString() + result;
    num/=2;
}
return int.Parse(result);
//result = (num / 2).ToString() + result;
Console.WriteLine(num, basic);