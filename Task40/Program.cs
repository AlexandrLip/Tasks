

using System;
using System.Linq;

Console.Clear();
int[] k=new int[20].Select(x=>new Random().Next(0,1000)).Where(x=>x>=9&&x<=100).ToArray();
Console.WriteLine(String.Join(" ",k));
