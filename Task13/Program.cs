
Console.Clear();

int num = new Random(). Next(10,100);
string numS=num.ToString();
int a1=Convert.ToInt32(numS[0].ToString());
int a2=Convert.ToInt32(numS[1].ToString());
//int a1=num/10;
//int a2=num%10;

if(a1>a2)
    Console.WriteLine($"{num}->{a1}");
else   
    Console.WriteLine($"{num}->{a2}");